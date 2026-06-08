using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Class MultiUpdater.
    /// </summary>
    /// <typeparam name="TValue">The type of value handled by the MultiUpdater.</typeparam>
    public class MultiUpdater<TValue> : IUpdater<TValue>
    {
        private readonly List<IUpdater>? updaters;

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiUpdater{TValue}"/> class using a collection of updaters.
        /// </summary>
        /// <param name="updaters">The collection of updaters to initialize the MultiUpdater with.</param>
        public MultiUpdater(IEnumerable<IUpdater> updaters)
        {
            this.updaters = updaters == null ? null : [.. updaters];
        }

        /// <summary>
        /// Gets the current value associated with the updater.
        /// </summary>
        public TValue? Value { get; set; }

        /// <summary>
        /// Performs an update operation and returns whether any changes were made.
        /// </summary>
        /// <returns>True if any changes were made; otherwise, false.</returns>
        public bool Update()
        {
            return Update(out _);
        }

        /// <summary>
        /// Performs an update operation and returns a boolean array indicating which specific updaters were modified.
        /// </summary>
        /// <param name="updated">When this method returns, contains a boolean array indicating which specific updaters were modified.</param>
        /// <returns>True if the update operation was successful; otherwise, false.</returns>
        public bool Update(out bool[]? updated)
        {
            updated = null;

            if (updaters is null || updaters.Count == 0)
            {
                return false;
            }

            Type? type_Value = Value?.GetType();
            if (type_Value is null)
            {
                return false;
            }

            updated = new bool[updaters.Count];
            for (int i = 0; i < updaters.Count; i++)
            {
                updated[i] = false;

                IUpdater updater = updaters[i];
                if (updater is null)
                {
                    continue;
                }

                Type type_Updater = updater.GetType();

                PropertyInfo propertyInfo = type_Updater.GetProperty("Value");
                if (propertyInfo is null)
                {
                    continue;
                }

                Type type_Property = propertyInfo.PropertyType;

                if (!type_Property.IsAssignableFrom(type_Value))
                {
                    continue;
                }

                propertyInfo.SetValue(updater, Value);

                updated[i] = updater.Update();

                if (updated[i] && propertyInfo.GetValue(updater) is TValue value)
                {
                    Value = value;
                    updated[i] = true;
                }
            }

            return updated.Contains(true);
        }
    }
}