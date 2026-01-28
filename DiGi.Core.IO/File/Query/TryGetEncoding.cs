using System.IO;
using System.Linq;

namespace DiGi.Core.IO.File
{
    public static partial class Query
    {
        public static bool TryGetEncoding(string? filePath, out System.Text.Encoding? encoding)
        {
            encoding = null;

            if (string.IsNullOrWhiteSpace(filePath) || !System.IO.File.Exists(filePath))
            {
                return false;
            }

            byte[] bytes = System.IO.File.ReadAllBytes(filePath);

            try
            {
                string text = System.Text.Encoding.UTF8.GetString(bytes);
                byte[] check = System.Text.Encoding.UTF8.GetBytes(text);

                if (check.SequenceEqual(bytes))
                {
                    using var reader = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                    byte[] bom = new byte[4];
                    reader.Read(bom, 0, 4);

                    // Check BOM

                    if (bom[0] == 0x2b && bom[1] == 0x2f && bom[2] == 0x76)
                    {
                        encoding = System.Text.Encoding.UTF7;
                        return true;
                    }

                    if (bom[0] == 0xef && bom[1] == 0xbb && bom[2] == 0xbf)
                    {
                        encoding = System.Text.Encoding.UTF8;
                        return true;
                    }

                    if (bom[0] == 0xff && bom[1] == 0xfe)
                    {
                        encoding = System.Text.Encoding.Unicode; //UTF-16 LE
                        return true;
                    }

                    if (bom[0] == 0xfe && bom[1] == 0xff)
                    {
                        encoding = System.Text.Encoding.BigEndianUnicode; //UTF-16 BE
                        return true;
                    }

                    if (bom[0] == 0 && bom[1] == 0 && bom[2] == 0xfe && bom[3] == 0xff)
                    {
                        encoding = System.Text.Encoding.UTF32;
                        return true;
                    }
                }
            }
            catch
            {
            }

            return false;
        }
    }
}