using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace DiGi.Core.Classes
{
    public class MultiUpdater<TValue> : IUpdater<TValue>
    {
        private readonly List<IUpdater>? updaters;

        public MultiUpdater(IEnumerable<IUpdater> updaters)
        {
            this.updaters = updaters == null ? null : [.. updaters];
        }

        public TValue? Value { get; set; }

        public bool Update()
        {
            return Update(out _);
        }

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