using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{
    /// <summary>
    /// Represents a named category that can contain hierarchical subcategories.
    /// </summary>
    [Description("Category")]
    public class Category : SerializableObject, IEquatable<Category>
    {
        [JsonInclude, JsonPropertyName(nameof(Name)), Description("Category Name")]
        private readonly string? name;

        [JsonIgnore]
        private Dictionary<string, Category>? dictionary;

        /// <summary>
        /// Initializes a new instance of the Category class with a specified name.
        /// </summary>
        /// <param name="name">The name of the category.</param>
        public Category(string? name)
            : base()
        {
            this.name = name;
        }

        /// <summary>
        /// Initializes a new instance of the Category class with a specified name and a collection of subcategories.
        /// </summary>
        /// <param name="name">The name of the category.</param>
        /// <param name="subCategories">The initial set of subcategories.</param>
        public Category(string? name, IEnumerable<Category>? subCategories)
        {
            this.name = name;
            if (subCategories != null)
            {
                foreach (Category subCategory in subCategories)
                {
                    Add(subCategory);
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Category class by cloning an existing category.
        /// </summary>
        /// <param name="category">The category to clone.</param>
        public Category(Category? category)
            : base(category)
        {
            if (category is not null)
            {
                name = category.Name;
                if (category.dictionary != null)
                {
                    dictionary = [];
                    foreach (KeyValuePair<string, Category> keyValuePair in category.dictionary)
                    {
                        dictionary[keyValuePair.Key] = keyValuePair.Value;
                    }
                }
            }
        }

        /// <summary>
        /// Initializes a new instance of the Category class from a JsonObject.
        /// </summary>
        /// <param name="jsonObject">The JSON object to deserialize.</param>
        public Category(JsonObject? jsonObject)
            : base(jsonObject)
        {
        }

        /// <summary>
        /// Gets the name of the category.
        /// </summary>
        [JsonIgnore]
        public string? Name
        {
            get
            {
                return name;
            }
        }

        /// <summary>
        /// Gets or sets the list of subcategories.
        /// </summary>
        [JsonInclude, JsonPropertyName("SubCategories"), Description("Category SubCategories")]
        public List<Category>? SubCategories
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<Category> result = [];
                foreach (Category? category in dictionary.Values)
                {
                    Category? category_Temp = Query.Clone(category);
                    if (category_Temp is null)
                    {
                        continue;
                    }

                    result.Add(category_Temp);
                }

                return result;
            }

            set
            {
                dictionary?.Clear();
                AddRange(value);
            }
        }

        /// <summary>
        /// Implicitly converts a string to a <see cref="Category"/> instance.
        /// </summary>
        /// <param name="name">The name of the category as a <see cref="string"/>.</param>
        /// <returns>A new <see cref="Category"/> instance created from the provided name, or null if the name is null.</returns>
        public static implicit operator Category?(string? name)
        {
            return new Category(name);
        }

        /// <summary>
        /// Implicitly converts a <see cref="Category"/> instance to its name as a string.
        /// </summary>
        /// <param name="category">The <see cref="Category"/> instance to convert.</param>
        /// <returns>The name of the category as a <see cref="string"/>, or null if the category is null.</returns>
        public static implicit operator string?(Category? category)
        {
            return category?.name;
        }

        /// <summary>
        /// Determines whether two Category instances are not equal.
        /// </summary>
        /// <param name="category_1">The first Category instance to compare.</param>
        /// <param name="category_2">The second Category instance to compare.</param>
        /// <returns>True if the two Category instances are not considered equal; otherwise, false.</returns>
        public static bool operator !=(Category? category_1, Category? category_2)
        {
            if (Equals(category_1, category_2))
            {
                return false;
            }

            if (Equals(category_1, null))
            {
                return true;
            }

            if (Equals(category_2, null))
            {
                return true;
            }

            return !category_1.Equals(category_2);
        }

        /// <summary>
        /// Determines whether two Category instances are equal.
        /// </summary>
        /// <param name="category_1">The first Category instance to compare.</param>
        /// <param name="category_2">The second Category instance to compare.</param>
        /// <returns>True if the two Category instances are considered equal; otherwise, false.</returns>
        public static bool operator ==(Category? category_1, Category? category_2)
        {
            if (Equals(category_1, category_2))
            {
                return true;
            }

            if (Equals(category_1, null))
            {
                return false;
            }

            if (Equals(category_2, null))
            {
                return false;
            }

            return category_1.Equals(category_2);
        }

        /// <summary>
        /// Adds a subcategory to the current category.
        /// </summary>
        /// <param name="category">The category to add.</param>
        /// <returns>True if the category was successfully added; otherwise, false.</returns>
        public bool Add(Category? category)
        {
            if (category?.Name == null)
            {
                return false;
            }

            dictionary ??= [];

            Category? category_Temp = category.Clone<Category>();
            if (category_Temp is null)
            {
                return false;
            }

            dictionary[category.Name] = category_Temp;
            return true;
        }

        /// <summary>
        /// Creates and adds a subcategory with the specified name.
        /// </summary>
        /// <param name="name">The name of the subcategory to add.</param>
        /// <returns>The newly created Category, or null if it could not be added.</returns>
        public Category? Add(string? name)
        {
            if (name == null)
            {
                return null;
            }

            Category result = new(name);

            return Add(result) ? result : null;
        }

        /// <summary>
        /// Adds a collection of subcategories to the current category.
        /// </summary>
        /// <param name="subCategories">The collection of categories to add.</param>
        public void AddRange(IEnumerable<Category>? subCategories)
        {
            if (subCategories == null)
            {
                return;
            }

            foreach (Category subCategory in subCategories)
            {
                Add(subCategory);
            }
        }

        /// <summary>
        /// Creates a deep copy of the current category.
        /// </summary>
        /// <returns>A cloned version of the category as an ISerializableObject.</returns>
        public override ISerializableObject? Clone()
        {
            Category result = new(name);
            if (dictionary != null)
            {
                foreach (Category category in dictionary.Values)
                {
                    result.Add(category);
                }
            }

            return result;
        }

        /// <summary>
        /// Determines whether the current Category is equal to another Category.
        /// </summary>
        /// <param name="category">The other category to compare with.</param>
        /// <returns>True if they are equal; otherwise, false.</returns>
        public bool Equals(Category? category)
        {
            if (category == null)
            {
                return false;
            }

            if (ReferenceEquals(this, category))
            {
                return true;
            }

            if (name != category.name)
            {
                return false;
            }

            if (dictionary == null && category.dictionary == null)
            {
                return true;
            }

            if (dictionary == null || category.dictionary == null)
            {
                return false;
            }

            if (dictionary.Count != category.dictionary.Count)
            {
                return false;
            }

            foreach (KeyValuePair<string, Category> keyValuePair in dictionary)
            {
                if (!category.dictionary.TryGetValue(keyValuePair.Key, out Category? value) || !keyValuePair.Value.Equals(value))
                {
                    return false;
                }
            }

            return true;
        }

        /// <summary>
        /// Determines whether the current Category is equal to a specified object.
        /// </summary>
        /// <param name="object">The object to compare with.</param>
        /// <returns>True if they are equal; otherwise, false.</returns>
        public override bool Equals(object? @object)
        {
            if (@object is not Category)
            {
                return false;
            }

            return Equals((Category)@object);
        }

        /// <summary>
        /// Returns a hash code for the current category based on its name and subcategories.
        /// </summary>
        /// <returns>A numeric hash code.</returns>
        public override int GetHashCode()
        {
            int result = 17;

            if (name != null)
            {
                result = result * 23 + name.GetHashCode();
            }

            if (dictionary != null)
            {
                foreach (Category subCategory in dictionary.Values)
                {
                    if (subCategory != null)
                    {
                        result = result * 23 + subCategory.GetHashCode();
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Returns a string that represents the current category's name.
        /// </summary>
        /// <returns>The category name.</returns>
        public override string? ToString()
        {
            return name?.ToString();
        }
    }
}