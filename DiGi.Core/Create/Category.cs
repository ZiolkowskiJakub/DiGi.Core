using DiGi.Core.Classes;
using System.Collections.Generic;
using System.Linq;

namespace DiGi.Core
{
    public static partial class Create
    {
        public static Category Category(this IEnumerable<string> names)
        {
            if(names == null || names.Count() == 0)
            {
                return null;
            }

            List<string> names_Temp = new List<string>(names);

            Category result = new Category(names_Temp[0]); 
            names_Temp.RemoveAt(0);

            Category category = result; 
            while(names_Temp.Count > 0)
            {
                Category category_Temp = new Category(names_Temp[0]);
                category.Add(category_Temp);

                category = category_Temp;

                names_Temp.RemoveAt(0);
            }

            return result;
        }
    }
}