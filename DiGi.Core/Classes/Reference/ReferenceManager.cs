using DiGi.Core.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Reflection;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Caches the <see cref="ReferenceConstructor"/> discovered for each reference type, so a reference string can be
    /// resolved back to the type that produced it.
    /// <para>Factories are found reflectively rather than through a hard-coded table, because DiGi.Core must be able
    /// to construct reference types defined in repositories that depend on it and that it therefore cannot
    /// reference.</para>
    /// </summary>
    public class ReferenceManager
    {
        private readonly ConcurrentDictionary<Assembly, bool> dictionary_Assembly = new();
        private readonly ConcurrentDictionary<string, ReferenceConstructor> dictionary_Discriminator = new();
        private readonly ConcurrentDictionary<Type, ReferenceConstructor> dictionary_Type = new();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReferenceManager"/> class.
        /// </summary>
        public ReferenceManager()
        {
        }

        /// <summary>
        /// Retrieves the reference constructor for a reference type, scanning its assembly on first use.
        /// </summary>
        /// <param name="type">The reference type.</param>
        /// <param name="update">Whether to scan for the factory when it is not already cached.</param>
        /// <returns>The reference constructor, or null when the type has no factory.</returns>
        public ReferenceConstructor? GetReferenceConstructor(Type? type, bool update = true)
        {
            if (type == null)
            {
                return null;
            }

            if (dictionary_Type.TryGetValue(type, out ReferenceConstructor? result))
            {
                return result;
            }

            if (!update || !typeof(IReference).IsAssignableFrom(type))
            {
                return null;
            }

            Scan(type.Assembly);

            dictionary_Type.TryGetValue(type, out result);

            return result;
        }

        /// <summary>
        /// Retrieves the reference constructor for a discriminator.
        /// <para>An assembly-qualified full type name is self-locating, so only its own assembly is scanned. A short
        /// kind token carries no assembly, so a miss falls back to scanning every loaded assembly that references
        /// DiGi.Core - which means a kind resolves only if its declaring assembly is already loaded.</para>
        /// </summary>
        /// <param name="discriminator">A kind token or an assembly-qualified full type name.</param>
        /// <param name="update">Whether to scan for the factory when it is not already cached.</param>
        /// <returns>The reference constructor, or null when the discriminator names no known reference type.</returns>
        public ReferenceConstructor? GetReferenceConstructor(string? discriminator, bool update = true)
        {
            if (string.IsNullOrWhiteSpace(discriminator))
            {
                return null;
            }

            if (dictionary_Discriminator.TryGetValue(discriminator!, out ReferenceConstructor? result))
            {
                return result;
            }

            if (!update)
            {
                return null;
            }

            if (discriminator!.Contains(","))
            {
                // TryParse now runs on arbitrary strings (e.g. through Query.TryConvert), so a discriminator can be a
                // whole JSON blob that merely happens to contain a comma. Query.Type can throw on such a malformed
                // name, and this lookup must stay total.
                Type? type;
                try
                {
                    type = Query.Type(discriminator);
                }
                catch (Exception)
                {
                    return null;
                }

                if (type == null || !typeof(IReference).IsAssignableFrom(type))
                {
                    return null;
                }

                Scan(type.Assembly);
            }
            else
            {
                ScanLoadedAssemblies();
            }

            dictionary_Discriminator.TryGetValue(discriminator, out result);

            return result;
        }

        /// <summary>
        /// Retrieves every reference constructor discoverable in the currently loaded assemblies.
        /// </summary>
        /// <returns>The reference constructors.</returns>
        public List<ReferenceConstructor> GetReferenceConstructors()
        {
            ScanLoadedAssemblies();

            return [.. dictionary_Type.Values];
        }

        private void Scan(Assembly? assembly)
        {
            if (assembly == null || assembly.IsDynamic || !dictionary_Assembly.TryAdd(assembly, true))
            {
                return;
            }

            Type[] types;
            try
            {
                types = assembly.GetTypes();
            }
            catch (ReflectionTypeLoadException reflectionTypeLoadException)
            {
                types = [.. System.Linq.Enumerable.Where(reflectionTypeLoadException.Types, x => x != null)!];
            }
            catch (Exception)
            {
                return;
            }

            foreach (Type type in types)
            {
                MethodInfo[] methodInfos;
                try
                {
                    methodInfos = type.GetMethods(BindingFlags.Public | BindingFlags.Static);
                }
                catch (Exception)
                {
                    continue;
                }

                foreach (MethodInfo methodInfo in methodInfos)
                {
                    ReferenceConstructor? referenceConstructor = Create.ReferenceConstructor(methodInfo);
                    if (referenceConstructor?.ReferenceType == null)
                    {
                        continue;
                    }

                    dictionary_Type.TryAdd(referenceConstructor.ReferenceType, referenceConstructor);

                    string? fullTypeName = referenceConstructor.FullTypeName;
                    if (!string.IsNullOrWhiteSpace(fullTypeName))
                    {
                        dictionary_Discriminator.TryAdd(fullTypeName!, referenceConstructor);
                    }

                    // First registration wins. A clashing kind is a build-time defect caught by the
                    // ReferenceKind facts, not something to resolve arbitrarily at runtime.
                    string? kind = referenceConstructor.Kind;
                    if (!string.IsNullOrWhiteSpace(kind))
                    {
                        dictionary_Discriminator.TryAdd(kind!, referenceConstructor);
                    }
                }
            }
        }

        private void ScanLoadedAssemblies()
        {
            Assembly assembly_Core = typeof(ReferenceFactoryAttribute).Assembly;

            Assembly[] assemblies;
            try
            {
                assemblies = AppDomain.CurrentDomain.GetAssemblies();
            }
            catch (Exception)
            {
                return;
            }

            foreach (Assembly assembly in assemblies)
            {
                // A factory has to reference DiGi.Core to apply the attribute, so anything that does not can be
                // skipped without loss - and that keeps this off the framework assemblies.
                if (assembly != assembly_Core && !References(assembly, assembly_Core))
                {
                    continue;
                }

                Scan(assembly);
            }
        }

        private static bool References(Assembly? assembly, Assembly? assembly_Referenced)
        {
            string? name = assembly_Referenced?.GetName()?.Name;
            if (assembly == null || string.IsNullOrWhiteSpace(name))
            {
                return false;
            }

            AssemblyName[] assemblyNames;
            try
            {
                assemblyNames = assembly.GetReferencedAssemblies();
            }
            catch (Exception)
            {
                return false;
            }

            foreach (AssemblyName assemblyName in assemblyNames)
            {
                if (assemblyName.Name == name)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
