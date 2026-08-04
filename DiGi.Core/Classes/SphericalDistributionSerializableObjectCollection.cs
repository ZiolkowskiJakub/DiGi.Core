using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a spherical distribution collection of serializable objects partitioned into azimuth and elevation bins.
    /// </summary>
    /// <typeparam name="TSerializableObject">The type of elements stored in the collection.</typeparam>
    public class SphericalDistributionSerializableObjectCollection<TSerializableObject> : SerializableObject where TSerializableObject : ISerializableObject
    {
        [JsonInclude, JsonPropertyName(nameof(AzimuthCount))]
        private readonly int azimuthCount;

        [JsonInclude, JsonPropertyName(nameof(AzimuthInterval))]
        private readonly double azimuthInterval;

        [JsonInclude, JsonPropertyName(nameof(AzimuthRange))]
        private readonly Range<double>? azimuthRange;

        [JsonInclude, JsonPropertyName(nameof(ElevationCount))]
        private readonly int elevationCount;

        [JsonInclude, JsonPropertyName(nameof(ElevationInterval))]
        private readonly double elevationInterval;

        [JsonInclude, JsonPropertyName(nameof(ElevationRange))]
        private readonly Range<double>? elevationRange;

        private List<TSerializableObject>[,]? values;

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection{TSerializableObject}"/> class.
        /// </summary>
        public SphericalDistributionSerializableObjectCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection{TSerializableObject}"/> class with specified range boundaries and intervals.
        /// </summary>
        /// <param name="minAzimuth">The minimum azimuth value.</param>
        /// <param name="maxAzimuth">The maximum azimuth value.</param>
        /// <param name="azimuthInterval">The azimuth bin interval size.</param>
        /// <param name="minElevation">The minimum elevation value.</param>
        /// <param name="maxElevation">The maximum elevation value.</param>
        /// <param name="elevationInterval">The elevation bin interval size.</param>
        public SphericalDistributionSerializableObjectCollection(double minAzimuth, double maxAzimuth, double azimuthInterval, double minElevation, double maxElevation, double elevationInterval)
            : this(new Range<double>(minAzimuth, maxAzimuth), azimuthInterval, new Range<double>(minElevation, maxElevation), elevationInterval)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection{TSerializableObject}"/> class with specified ranges and intervals.
        /// </summary>
        /// <param name="azimuthRange">The azimuth range.</param>
        /// <param name="azimuthInterval">The azimuth bin interval size.</param>
        /// <param name="elevationRange">The elevation range.</param>
        /// <param name="elevationInterval">The elevation bin interval size.</param>
        public SphericalDistributionSerializableObjectCollection(Range<double>? azimuthRange, double azimuthInterval, Range<double>? elevationRange, double elevationInterval)
            : base()
        {
            if (azimuthRange == null || elevationRange == null || azimuthInterval <= 0 || elevationInterval <= 0)
            {
                return;
            }

            this.azimuthRange = azimuthRange;
            this.azimuthInterval = azimuthInterval;
            this.elevationRange = elevationRange;
            this.elevationInterval = elevationInterval;

            azimuthCount = (int)Math.Ceiling(azimuthRange.Length / azimuthInterval);
            elevationCount = (int)Math.Ceiling(elevationRange.Length / elevationInterval);

            if (azimuthCount <= 0 || elevationCount <= 0)
            {
                return;
            }

            values = new List<TSerializableObject>[azimuthCount, elevationCount];
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection{TSerializableObject}"/> class by copying another instance.
        /// </summary>
        /// <param name="sphericalDistributionCollection">The collection to copy from.</param>
        public SphericalDistributionSerializableObjectCollection(SphericalDistributionSerializableObjectCollection<TSerializableObject>? sphericalDistributionCollection)
            : base(sphericalDistributionCollection)
        {
            if (sphericalDistributionCollection == null)
            {
                return;
            }

            if (sphericalDistributionCollection.azimuthRange != null)
            {
                azimuthRange = new Range<double>(sphericalDistributionCollection.azimuthRange);
            }

            azimuthInterval = sphericalDistributionCollection.azimuthInterval;
            azimuthCount = sphericalDistributionCollection.azimuthCount;

            if (sphericalDistributionCollection.elevationRange != null)
            {
                elevationRange = new Range<double>(sphericalDistributionCollection.elevationRange);
            }

            elevationInterval = sphericalDistributionCollection.elevationInterval;
            elevationCount = sphericalDistributionCollection.elevationCount;

            if (azimuthCount > 0 && elevationCount > 0)
            {
                values = new List<TSerializableObject>[azimuthCount, elevationCount];
                if (sphericalDistributionCollection.values != null)
                {
                    for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
                    {
                        for (int elIndex = 0; elIndex < elevationCount; elIndex++)
                        {
                            List<TSerializableObject>? sourceBin = sphericalDistributionCollection.values[azIndex, elIndex];
                            if (sourceBin != null)
                            {
                                List<TSerializableObject> targetBin = [];
                                foreach (TSerializableObject item in sourceBin)
                                {
                                    if (Query.Clone(item) is TSerializableObject item_Temp)
                                    {
                                        targetBin.Add(item_Temp);
                                    }
                                }

                                values[azIndex, elIndex] = targetBin;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection{TSerializableObject}"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public SphericalDistributionSerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the azimuth count of bins.
        /// </summary>
        [JsonIgnore]
        public int AzimuthCount => azimuthCount;

        /// <summary>
        /// Gets the azimuth interval.
        /// </summary>
        [JsonIgnore]
        public double AzimuthInterval => azimuthInterval;

        /// <summary>
        /// Gets the azimuth range.
        /// </summary>
        [JsonIgnore]
        public Range<double>? AzimuthRange => azimuthRange;

        /// <summary>
        /// Gets the total number of items stored across all bins.
        /// </summary>
        [JsonIgnore]
        public int Count
        {
            get
            {
                if (values == null)
                {
                    return 0;
                }

                int count = 0;
                for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
                {
                    for (int elIndex = 0; elIndex < elevationCount; elIndex++)
                    {
                        List<TSerializableObject>? bin = values[azIndex, elIndex];
                        if (bin != null)
                        {
                            count += bin.Count;
                        }
                    }
                }

                return count;
            }
        }

        /// <summary>
        /// Gets the elevation count of bins.
        /// </summary>
        [JsonIgnore]
        public int ElevationCount => elevationCount;

        /// <summary>
        /// Gets the elevation interval.
        /// </summary>
        [JsonIgnore]
        public double ElevationInterval => elevationInterval;

        /// <summary>
        /// Gets the elevation range.
        /// </summary>
        [JsonIgnore]
        public Range<double>? ElevationRange => elevationRange;

        /// <summary>
        /// Gets all stored elements across all bins as a flat read-only list.
        /// </summary>
        [JsonIgnore]
        public IReadOnlyList<TSerializableObject> Values
        {
            get
            {
                List<TSerializableObject> result = [];
                if (values != null)
                {
                    for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
                    {
                        for (int elIndex = 0; elIndex < elevationCount; elIndex++)
                        {
                            List<TSerializableObject>? bin = values[azIndex, elIndex];
                            if (bin != null)
                            {
                                result.AddRange(bin);
                            }
                        }
                    }
                }

                return result;
            }
        }

        /// <summary>
        /// Adds an item to the bin corresponding to the given coordinates.
        /// </summary>
        /// <param name="azimuth">The azimuth coordinate.</param>
        /// <param name="elevation">The elevation coordinate.</param>
        /// <param name="value">The item to add.</param>
        public void AddValue(double azimuth, double elevation, TSerializableObject? value)
        {
            if (value is null || values == null || azimuthRange == null || elevationRange == null)
            {
                return;
            }

            int azimuthIndex = GetAzimuthIndex(azimuth);
            int elevationIndex = GetElevationIndex(elevation);

            if (azimuthIndex < 0 || azimuthIndex >= azimuthCount || elevationIndex < 0 || elevationIndex >= elevationCount)
            {
                return;
            }

            values[azimuthIndex, elevationIndex] ??= [];
            values[azimuthIndex, elevationIndex].Add(value);
        }

        /// <summary>
        /// Adds multiple items to the bin corresponding to the given coordinates.
        /// </summary>
        /// <param name="azimuth">The azimuth coordinate.</param>
        /// <param name="elevation">The elevation coordinate.</param>
        /// <param name="values">The collection of items to add.</param>
        public void AddValues(double azimuth, double elevation, IEnumerable<TSerializableObject>? values)
        {
            if (values is null || !values.Any() || this.values == null || azimuthRange == null || elevationRange == null)
            {
                return;
            }

            int azimuthIndex = GetAzimuthIndex(azimuth);
            int elevationIndex = GetElevationIndex(elevation);

            if (azimuthIndex < 0 || azimuthIndex >= azimuthCount || elevationIndex < 0 || elevationIndex >= elevationCount)
            {
                return;
            }

            this.values[azimuthIndex, elevationIndex] ??= [];
            this.values[azimuthIndex, elevationIndex].AddRange(values.Where(x => x != null));
        }

        /// <summary>
        /// Clears all items stored in all bins.
        /// </summary>
        public void Clear()
        {
            if (values == null)
            {
                return;
            }

            for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
            {
                for (int elIndex = 0; elIndex < elevationCount; elIndex++)
                {
                    values[azIndex, elIndex]?.Clear();
                }
            }
        }

        /// <summary>
        /// Populates the instance properties and grid bins from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object containing serialized data.</param>
        /// <returns>True if population succeeded; otherwise, false.</returns>
        public override bool FromJsonObject(JsonObject? jsonObject)
        {
            if (jsonObject is null)
            {
                return false;
            }

            bool result = base.FromJsonObject(jsonObject);
            if (!result)
            {
                return result;
            }

            if (azimuthCount > 0 && elevationCount > 0)
            {
                List<TSerializableObject>[,] grid = new List<TSerializableObject>[azimuthCount, elevationCount];

                if (jsonObject.TryGetPropertyValue("Bins", out JsonNode? jsonNode_Bins) && jsonNode_Bins is JsonArray jsonArray_Bins)
                {
                    foreach (JsonNode? jsonNode_Bin in jsonArray_Bins)
                    {
                        if (jsonNode_Bin is not JsonObject jsonObject_Bin)
                        {
                            continue;
                        }

                        if (!jsonObject_Bin.TryGetPropertyValue("AzimuthIndex", out JsonNode? jsonNode_AzIndex) ||
                            !jsonObject_Bin.TryGetPropertyValue("ElevationIndex", out JsonNode? jsonNode_ElIndex) ||
                            !jsonObject_Bin.TryGetPropertyValue("Items", out JsonNode? jsonNode_Items))
                        {
                            continue;
                        }

                        if (jsonNode_AzIndex is null || jsonNode_ElIndex is null || jsonNode_Items is not JsonArray jsonArray_Items)
                        {
                            continue;
                        }

                        int azIndex = (int)jsonNode_AzIndex;
                        int elIndex = (int)jsonNode_ElIndex;

                        if (azIndex < 0 || azIndex >= azimuthCount || elIndex < 0 || elIndex >= elevationCount)
                        {
                            continue;
                        }

                        List<TSerializableObject> binItems = [];
                        foreach (JsonNode? jsonNode_Item in jsonArray_Items)
                        {
                            if (jsonNode_Item is null)
                            {
                                continue;
                            }

                            object? value = Query.Value(jsonNode_Item, typeof(TSerializableObject));
                            if (value is TSerializableObject item)
                            {
                                binItems.Add(item);
                            }
                        }

                        if (binItems.Count > 0)
                        {
                            grid[azIndex, elIndex] = binItems;
                        }
                    }
                }

                values = grid;
            }

            return result;
        }

        /// <summary>
        /// Gets the azimuth range corresponding to the specified azimuth index, starting from minimum azimuth.
        /// </summary>
        /// <param name="azimuthIndex">The zero-based azimuth index.</param>
        /// <returns>The azimuth range for the specified index, or null if the index is out of bounds.</returns>
        public Range<double>? GetAzimuthRange(int azimuthIndex)
        {
            if (azimuthRange == null || azimuthIndex < 0 || azimuthIndex >= azimuthCount || azimuthInterval <= 0)
            {
                return null;
            }

            double min = azimuthRange.Min + (azimuthIndex * azimuthInterval);
            double max = azimuthRange.Min + ((azimuthIndex + 1) * azimuthInterval);
            return new Range<double>(min, max);
        }

        /// <summary>
        /// Gets a list of azimuth ranges for all partitions, optionally filtering to populated partitions only.
        /// </summary>
        /// <param name="populatedOnly">If true, returns azimuth ranges only for partitions containing at least one item.</param>
        /// <returns>A list of azimuth ranges, or null if grid is uninitialized.</returns>
        public List<Range<double>>? GetAzimuthRanges(bool populatedOnly = false)
        {
            if (azimuthRange == null || azimuthCount <= 0 || azimuthInterval <= 0)
            {
                return null;
            }

            List<Range<double>> result = [];
            for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
            {
                if (populatedOnly)
                {
                    bool isPopulated = false;
                    if (values != null)
                    {
                        for (int elIndex = 0; elIndex < elevationCount; elIndex++)
                        {
                            List<TSerializableObject>? bin = values[azIndex, elIndex];
                            if (bin != null && bin.Count > 0)
                            {
                                isPopulated = true;
                                break;
                            }
                        }
                    }

                    if (!isPopulated)
                    {
                        continue;
                    }
                }

                Range<double>? range = GetAzimuthRange(azIndex);
                if (range != null)
                {
                    result.Add(range);
                }
            }

            return result;
        }

        /// <summary>
        /// Gets the elevation range corresponding to the specified elevation index, starting from minimum elevation.
        /// </summary>
        /// <param name="elevationIndex">The zero-based elevation index.</param>
        /// <returns>The elevation range for the specified index, or null if the index is out of bounds.</returns>
        public Range<double>? GetElevationRange(int elevationIndex)
        {
            if (elevationRange == null || elevationIndex < 0 || elevationIndex >= elevationCount || elevationInterval <= 0)
            {
                return null;
            }

            double min = elevationRange.Min + (elevationIndex * elevationInterval);
            double max = elevationRange.Min + ((elevationIndex + 1) * elevationInterval);
            return new Range<double>(min, max);
        }

        /// <summary>
        /// Gets a list of elevation ranges for all partitions, optionally filtering to populated partitions only.
        /// </summary>
        /// <param name="populatedOnly">If true, returns elevation ranges only for partitions containing at least one item.</param>
        /// <returns>A list of elevation ranges, or null if grid is uninitialized.</returns>
        public List<Range<double>>? GetElevationRanges(bool populatedOnly = false)
        {
            if (elevationRange == null || elevationCount <= 0 || elevationInterval <= 0)
            {
                return null;
            }

            List<Range<double>> result = [];
            for (int elIndex = 0; elIndex < elevationCount; elIndex++)
            {
                if (populatedOnly)
                {
                    bool isPopulated = false;
                    if (values != null)
                    {
                        for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
                        {
                            List<TSerializableObject>? bin = values[azIndex, elIndex];
                            if (bin != null && bin.Count > 0)
                            {
                                isPopulated = true;
                                break;
                            }
                        }
                    }

                    if (!isPopulated)
                    {
                        continue;
                    }
                }

                Range<double>? range = GetElevationRange(elIndex);
                if (range != null)
                {
                    result.Add(range);
                }
            }

            return result;
        }

        /// <summary>
        /// Retrieves items stored in the exact bin corresponding to the given coordinates.
        /// </summary>
        /// <param name="azimuth">The azimuth coordinate.</param>
        /// <param name="elevation">The elevation coordinate.</param>
        /// <returns>A read-only list of items stored at the given coordinates.</returns>
        public IReadOnlyList<TSerializableObject>? GetValues(double azimuth, double elevation)
        {
            if (values == null || azimuthRange == null || elevationRange == null)
            {
                return [];
            }

            int azimuthIndex = GetAzimuthIndex(azimuth);
            int elevationIndex = GetElevationIndex(elevation);

            if (azimuthIndex < 0 || azimuthIndex >= azimuthCount || elevationIndex < 0 || elevationIndex >= elevationCount)
            {
                return [];
            }

            List<TSerializableObject>? result = values[azimuthIndex, elevationIndex];
            return result ?? [];
        }

        /// <summary>
        /// Retrieves items stored within specified range bounds.
        /// </summary>
        /// <param name="azimuthRange">The range of azimuth coordinates.</param>
        /// <param name="elevationRange">The range of elevation coordinates.</param>
        /// <returns>A read-only list of items matching the criteria, or null if ranges are null.</returns>
        public IReadOnlyList<TSerializableObject>? GetValues(Range<double>? azimuthRange, Range<double>? elevationRange)
        {
            if (azimuthRange is null || elevationRange is null)
            {
                return null;
            }

            return GetValues(azimuthRange.Min, azimuthRange.Max, elevationRange.Min, elevationRange.Max);
        }

        /// <summary>
        /// Retrieves all items within the specified bounds, handling internal wrap-around for azimuth.
        /// </summary>
        /// <param name="startAzimuth">The starting azimuth coordinate.</param>
        /// <param name="endAzimuth">The ending azimuth coordinate.</param>
        /// <param name="startElevation">The starting elevation coordinate.</param>
        /// <param name="endElevation">The ending elevation coordinate.</param>
        /// <returns>A read-only list of items within the bounds.</returns>
        public IReadOnlyList<TSerializableObject>? GetValues(double startAzimuth, double endAzimuth, double startElevation, double endElevation)
        {
            if (values == null || azimuthRange == null || elevationRange == null)
            {
                return [];
            }

            List<TSerializableObject> resultItems = [];

            int startElevationIndex = GetElevationIndex(startElevation);
            int endElevationIndex = GetElevationIndex(endElevation);

            if (startElevationIndex > endElevationIndex)
            {
                (startElevationIndex, endElevationIndex) = (endElevationIndex, startElevationIndex);
            }

            List<int> elevationIndices = [];
            for (int i = startElevationIndex; i <= endElevationIndex; i++)
            {
                elevationIndices.Add(i);
            }

            List<int> azimuthIndices = [];
            bool spansEntireDomain = Math.Abs(endAzimuth - startAzimuth) >= azimuthRange.Length;

            if (spansEntireDomain)
            {
                for (int i = 0; i < azimuthCount; i++)
                {
                    azimuthIndices.Add(i);
                }
            }
            else
            {
                int startAzimuthIndex = GetAzimuthIndex(startAzimuth);
                int endAzimuthIndex = GetAzimuthIndex(endAzimuth);

                int currentIndex = startAzimuthIndex;

                while (true)
                {
                    azimuthIndices.Add(currentIndex);

                    if (currentIndex == endAzimuthIndex)
                    {
                        break;
                    }

                    currentIndex = (currentIndex + 1) % azimuthCount;

                    if (azimuthIndices.Count > azimuthCount)
                    {
                        break;
                    }
                }
            }

            foreach (int azIndex in azimuthIndices)
            {
                foreach (int elIndex in elevationIndices)
                {
                    List<TSerializableObject>? binContent = values[azIndex, elIndex];
                    if (binContent != null)
                    {
                        resultItems.AddRange(binContent);
                    }
                }
            }

            return resultItems;
        }

        /// <summary>
        /// Converts the current instance into a JsonObject representation.
        /// </summary>
        /// <returns>A JsonObject representation, or null.</returns>
        public override JsonObject? ToJsonObject()
        {
            JsonObject? result = base.ToJsonObject();
            if (result == null)
            {
                return null;
            }

            if (values != null && azimuthCount > 0 && elevationCount > 0)
            {
                JsonArray jsonArray_Bins = [];
                for (int azIndex = 0; azIndex < azimuthCount; azIndex++)
                {
                    for (int elIndex = 0; elIndex < elevationCount; elIndex++)
                    {
                        List<TSerializableObject>? binContent = values[azIndex, elIndex];
                        if (binContent != null && binContent.Count > 0)
                        {
                            JsonObject jsonObject_Bin = new()
                            {
                                { "AzimuthIndex", azIndex },
                                { "ElevationIndex", elIndex }
                            };

                            JsonArray jsonArray_Items = [];
                            foreach (TSerializableObject item in binContent)
                            {
                                JsonNode? jsonNode_Item = Create.JsonNode(item);
                                if (jsonNode_Item != null)
                                {
                                    jsonArray_Items.Add(jsonNode_Item);
                                }
                            }

                            jsonObject_Bin["Items"] = jsonArray_Items;
                            jsonArray_Bins.Add(jsonObject_Bin);
                        }
                    }
                }

                result["Bins"] = jsonArray_Bins;
            }

            return result;
        }

        /// <summary>
        /// Maps an azimuth value to the corresponding 0-based array index using the defined domain starting from minimum azimuth.
        /// </summary>
        private int GetAzimuthIndex(double azimuth)
        {
            if (azimuthRange == null || azimuthRange.Length <= 0 || azimuthCount <= 0 || azimuthInterval <= 0)
            {
                return 0;
            }

            double localAzimuth = (azimuth - azimuthRange.Min) % azimuthRange.Length;
            if (localAzimuth < 0)
            {
                localAzimuth += azimuthRange.Length;
            }

            if (localAzimuth <= 0)
            {
                return 0;
            }

            int index = (int)Math.Ceiling(localAzimuth / azimuthInterval) - 1;

            if (index < 0)
            {
                index = 0;
            }

            if (index >= azimuthCount)
            {
                index = azimuthCount - 1;
            }

            return index;
        }

        /// <summary>
        /// Maps an elevation value to the corresponding 0-based array index using the defined domain starting from minimum elevation.
        /// </summary>
        private int GetElevationIndex(double elevation)
        {
            if (elevationRange == null || elevationCount <= 0 || elevationInterval <= 0)
            {
                return 0;
            }

            double clampedElevation = Math.Max(elevationRange.Min, Math.Min(elevationRange.Max, elevation));

            double localElevation = clampedElevation - elevationRange.Min;

            if (localElevation <= 0)
            {
                return 0;
            }

            int index = (int)Math.Ceiling(localElevation / elevationInterval) - 1;

            if (index < 0)
            {
                index = 0;
            }

            if (index >= elevationCount)
            {
                index = elevationCount - 1;
            }

            return index;
        }
    }

    /// <summary>
    /// Non-generic version of SphericalDistributionSerializableObjectCollection for handling a collection of ISerializableObjects.
    /// </summary>
    public class SphericalDistributionSerializableObjectCollection : SphericalDistributionSerializableObjectCollection<ISerializableObject>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection"/> class.
        /// </summary>
        public SphericalDistributionSerializableObjectCollection()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection"/> class with specified range boundaries and intervals.
        /// </summary>
        /// <param name="minAzimuth">The minimum azimuth value.</param>
        /// <param name="maxAzimuth">The maximum azimuth value.</param>
        /// <param name="azimuthInterval">The azimuth bin interval size.</param>
        /// <param name="minElevation">The minimum elevation value.</param>
        /// <param name="maxElevation">The maximum elevation value.</param>
        /// <param name="elevationInterval">The elevation bin interval size.</param>
        public SphericalDistributionSerializableObjectCollection(
            double minAzimuth,
            double maxAzimuth,
            double azimuthInterval,
            double minElevation,
            double maxElevation,
            double elevationInterval)
            : base(minAzimuth, maxAzimuth, azimuthInterval, minElevation, maxElevation, elevationInterval)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection"/> class with specified ranges and intervals.
        /// </summary>
        /// <param name="azimuthRange">The azimuth range.</param>
        /// <param name="azimuthInterval">The azimuth bin interval size.</param>
        /// <param name="elevationRange">The elevation range.</param>
        /// <param name="elevationInterval">The elevation bin interval size.</param>
        public SphericalDistributionSerializableObjectCollection(Range<double>? azimuthRange, double azimuthInterval, Range<double>? elevationRange, double elevationInterval)
            : base(azimuthRange, azimuthInterval, elevationRange, elevationInterval)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection"/> class by copying another collection.
        /// </summary>
        /// <param name="sphericalDistributionCollection">The collection to copy from.</param>
        public SphericalDistributionSerializableObjectCollection(SphericalDistributionSerializableObjectCollection? sphericalDistributionCollection)
            : base(sphericalDistributionCollection)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SphericalDistributionSerializableObjectCollection"/> class from a JSON object.
        /// </summary>
        /// <param name="jsonObject">The JSON object to initialize from.</param>
        public SphericalDistributionSerializableObjectCollection(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Creates a new object that is a copy of the current instance.
        /// </summary>
        /// <returns>A new object that is a copy of this instance.</returns>
        public override ISerializableObject? Clone()
        {
            return new SphericalDistributionSerializableObjectCollection(this);
        }
    }
}