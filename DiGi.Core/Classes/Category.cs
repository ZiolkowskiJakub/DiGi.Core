using DiGi.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace DiGi.Core.Classes
{

    [Description("Category")]
    public class Category : SerializableObject, IEquatable<Category>
    {
        [JsonIgnore]
        private Dictionary<string, Category> dictionary;

        [JsonInclude, JsonPropertyName("Name"), Description("Category Name")]
        private string name;
        public Category(string name)
            :base()
        {
            this.name = name;
        }

        public Category(string name, IEnumerable<Category> subCategories)
        {
            this.name = name;
            if (subCategories != null)
            {
                foreach(Category subCategory in subCategories)
                {
                    Add(subCategory);
                }
            }
        }

        public Category(JsonObject jsonObject)
            : base(jsonObject)
        {

        }

        public Category(Category category)
            :base()
        {
            if(category != null)
            {
                name = category.Name;
            }
        }

        [JsonIgnore]
        public string Name
        {
            get
            {
                return name;
            }
        }

        [JsonInclude, JsonPropertyName("SubCategories"), Description("Category SubCategories")]
        public List<Category> SubCategories
        {
            get
            {
                if (dictionary == null)
                {
                    return null;
                }

                List<Category> result = new List<Category>();
                foreach (Category category in dictionary.Values)
                {
                    result.Add(category?.Clone<Category>());
                }

                return result;
            }

            set
            {
                dictionary.Clear();
                AddRange(value);
            }
        }

        
        public static implicit operator Category(string name)
        {
            return new Category(name);
        }

        
        public static implicit operator string(Category category)
        {
            return category.name;
        }

        public static bool operator !=(Category category_1, Category category_2)
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

        public static bool operator ==(Category category_1, Category category_2)
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

        public bool Add(Category category)
        {
            if (category?.Name == null)
            {
                return false;
            }

            if (dictionary == null)
            {
                dictionary = new Dictionary<string, Category>();
            }

            dictionary[category.Name] = category.Clone<Category>();
            return true;
        }

        public Category Add(string name)
        {
            if(name == null)
            {
                return null;
            }

            Category result = new Category(name);

            return Add(result) ? result : null;
        }

        public void AddRange(IEnumerable<Category> subCategories)
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

        public override ISerializableObject Clone()
        {
            Category result = new Category(name);
            if(dictionary != null)
            {
                dictionary = new Dictionary<string, Category>();
                foreach(Category category in dictionary.Values)
                {
                    result.Add(category);
                }
            }

            return result;
        }
        
        public bool Equals(Category category)
        {
            if(category == null)
            {
                return false;
            }

            return GetHashCode() == category.GetHashCode();
        }

        public override bool Equals(object @object)
        {
            if(!(@object is Category))
            {
                return false;
            }

            return Equals((Category)@object);
        }

        public override int GetHashCode()
        {
            int result = 17;

            if(name != null)
            {
                result = result * 23 + name.GetHashCode();
            }

            if(dictionary != null)
            {
                foreach(Category subCategory in dictionary.Values)
                {
                    if(subCategory != null)
                    {
                        result = result * 23 + subCategory.GetHashCode();
                    }
                }
            }


            return result;
        }

        public override string ToString()
        {
            return name?.ToString();
        }
    }
}
