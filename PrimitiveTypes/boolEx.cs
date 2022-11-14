using System;
using System.Text;


namespace TrainingSkeleton_SonDXT.PrimitiveTypes
{
    internal class boolEx
    {
        public void bool1()
        {
            //string str;
            Console.WriteLine("Nhập vào chuỗi: ");
            string str = Console.ReadLine();
            if (str == "true" || str == "false")
            {
                Console.WriteLine("Chuỗi hợp lệ");
            }
            else
            {
                Console.WriteLine("Chuỗi không hợp lệ, không phải là chuỗi boolen");
            }
        }
    }
}
