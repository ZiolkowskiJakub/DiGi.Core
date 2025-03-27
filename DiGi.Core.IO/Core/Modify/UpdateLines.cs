using System;
using System.Collections.Generic;
using System.IO;

namespace DiGi.Core.IO
{
    public static partial class Modify
    {
        public static HashSet<int> UpdateLines(string path, Dictionary<int, string> lineDictionary)
        {
            if (string.IsNullOrWhiteSpace(path) || !System.IO.File.Exists(path) || lineDictionary == null)
            {
                return null;
            }

            string path_Temp = Path.GetTempFileName();


            HashSet<int> result = null;

            try
            {
                
                using (StreamReader streamReader = new StreamReader(path))
                {
                    using (StreamWriter streamWriter = new StreamWriter(path_Temp))
                    {
                        result = new HashSet<int>();

                        int index = 0;

                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            if (lineDictionary.TryGetValue(index, out string line_Temp))
                            {
                                line = line_Temp;
                                result.Add(index);
                            }

                            streamWriter.WriteLine(line);
                            index++;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                System.IO.File.Delete(path_Temp);
;
            }

            if (System.IO.File.Exists(path_Temp))
            {
                System.IO.File.Delete(path);
                System.IO.File.Move(path_Temp, path);
            }

            return result;
        }
    }

}


