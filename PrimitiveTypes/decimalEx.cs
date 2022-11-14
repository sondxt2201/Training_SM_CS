using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using static System.Net.Mime.MediaTypeNames;


namespace TrainingSkeleton_SonDXT.PrimitiveTypes
{
    internal class decimalEx
    {
        public void decimal1()
        {
            string str;
            Regex reg = new Regex(@"((\d{1,4})|(\d{2,3}(\,\d{3})+)|(\d(\,\d{3}){2,}))(\.\d{0,5})?");
            Console.WriteLine("Nhập vào chuỗi: ");
            str = Console.ReadLine();
            bool b = reg.IsMatch(str);
            if (b)
            {
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi decimal");
            }
        }

        public void decimal2()
        {
            decimal dec;
            Console.WriteLine("Nhập vào chuỗi: ");
            bool b = decimal.TryParse(Console.ReadLine(), out dec);
            while (!b)
            {
                Console.WriteLine("Không phải chuỗi decimal, hãy nhập lại");
                b = decimal.TryParse(Console.ReadLine(), out dec);
            }
            CultureInfo ci = new CultureInfo("en-us");
            Console.WriteLine("Chuỗi vừa nhập dưới dạng Decimal là: {0}", dec.ToString("N02", ci));
        }
    }
}
