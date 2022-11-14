using System;
using System.Text;

namespace TrainingSkeleton_SonDXT.PrimitiveTypes
{
    internal class stringEx
    {
        public void string1(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("Chuỗi bị null hoặc rỗng.");
            }
            else if (string.IsNullOrWhiteSpace(str))
            {
                Console.WriteLine("Chuỗi space.");
            }
            else
            {
                Console.WriteLine($"Chuỗi vừa nhập là: \'{str}\'");
            }
        }

        public void string2(string str)
        {
            string1(str);
            Console.WriteLine($"Chuỗi bỏ cách ở đầu và cuối:\'{str.Trim()}\'");
        }

        public void string3(string str)
        {
            string1(str);
            Console.WriteLine("Chuỗi bỏ hết ký tự trắng: " + str.Trim().Replace(" ", string.Empty));
        }

        public void string4(string str)
        {
            string1(str);
            char[] array = str.ToCharArray();
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }
            }
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] == ' ')
                {
                    array[i] = char.ToUpper(array[i]);
                }
            }

            Console.WriteLine("Chuỗi kí tự sau khi viết hoa chữ cái sau dấu Space: " + new String(array));

        }

        public void string5(string str)
        {
            string1(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                    count++;
            }
            Console.WriteLine($"có {count} ký tự space.");
        }

        public void string6(string str)
        {
            string1(str);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] != ' ')
                    count++;
            }
            Console.WriteLine($"có {count} ký tự không phải space.");
        }

        public void string7(string str1, string str2)
        {
            bool b = string.Equals(str1, str2);
            if (b)
            {
                Console.WriteLine($"Chuỗi '{str1}' giống chuỗi '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Chuỗi '{str1}' khác chuỗi '{str2}'.");

            }
        }

        public void string8(string str1, string str2)
        {
            bool b = string.Equals(str1, str2, StringComparison.OrdinalIgnoreCase);
            if (b)
            {
                Console.WriteLine($"Chuỗi '{str1}' giống chuỗi '{str2}'.");
            }
            else
            {
                Console.WriteLine($"Chuỗi '{str1}' khác chuỗi '{str2}'.");

            }
        }

        public void string9(string str)
        {
            string1(str);
            str.Replace("ABC", "DEF");
            Console.WriteLine(str);
        }

        public void string10(string str)
        {
            string1(str);
            Console.WriteLine($"Kính chào ông {str}, chúc ngon miệng.");
        }

        public void string11(string str)
        {
            string1(str);
            char[] array = str.ToCharArray();
            string str2 = String.Empty;
            for (int i = array.Length - 1; i > -1; i--)
            {
                str2 += str[i];
            }
            Console.WriteLine("Chuỗi sau khi được đảo lại là: " + str2);
        }

        public void string12(string str, int count)
        {
            string1(str);
            string str2 = String.Empty;

            if (count < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0.");
            }
            else
            {
                str2 = str.TrimStart();
                Console.WriteLine("Chuỗi bỏ ký tự trắng ở đầu là: " + str2);
                Console.WriteLine($"Chuỗi sau khi cắt bỏ {count} ký tự đầu là: " + str2.Substring(count, str2.Length - count));
            }

        }

        public void string13(string str, int count)
        {
            string1(str);
            string str2 = String.Empty;

            if (count < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0.");
            }
            else
            {
                str2 = str.Trim();
                Console.WriteLine("Chuỗi bỏ ký tự trắng ở đầu và cuối là: " + str2);
                Console.WriteLine($"Chuỗi sau khi cắt bỏ {count} ký tự đầu là: " + str2.Substring(count, str2.Length - count));
            }

        }

        public void string14(string str, int count)
        {
            string1(str);
            string str2 = String.Empty;

            if (count < 0)
            {
                Console.WriteLine("Số nhỏ hơn 0.");
            }
            else
            {
                str2 = str.Trim();
                Console.WriteLine("Chuỗi bỏ ký tự trắng ở đầu và cuối là: " + str2);
                Console.WriteLine($"Chuỗi sau khi cắt bỏ {count} ký tự cuối là: " + str2.Substring(0, str2.Length - count));
            }

        }
    }
}

