using System;
using System.Text;
using System.Xml.Serialization;

namespace TrainingSkeleton_SonDXT.PrimitiveTypes
{
    internal class intEx
    {

        public void int1()
        {
            Console.WriteLine("Nhập vào số: ");
            int number;
            bool b = int.TryParse(Console.ReadLine(), out number);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = int.TryParse(Console.ReadLine(), out number);

            }

            if (number <= 0)
            {
                Console.WriteLine("Số <= 0");
            }
            else if ((number % 2) == 0)
            {
                Console.WriteLine("Số chẵn");
            }
            else
            {
                Console.WriteLine("Số lẻ");
            }
        }

        public void int2()
        {
            Console.WriteLine("Nhập vào số: ");
            int number;
            bool b = int.TryParse(Console.ReadLine(), out number);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = int.TryParse(Console.ReadLine(), out number);
            }
            Console.WriteLine("Giá trị tuyệt đối của x là: " + Math.Abs(number));
        }

        public void int3()
        {
            Console.WriteLine("Nhập vào số: ");
            int number;
            bool b = int.TryParse(Console.ReadLine(), out number);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = int.TryParse(Console.ReadLine(), out number);
            }
            if (number <= 0)
            {
                Console.WriteLine("Số <= 0");
            }
            else
            {
                Console.WriteLine($"2^{number} = " + Math.Pow(2, number));
            }
        }

        public void int4()
        {
            int num1;
            int num2;

            Console.WriteLine("Nhập vào số thứ 1: ");
            var tmp1 = Console.ReadLine();
            bool b1 = int.TryParse(tmp1, out num1);

            Console.WriteLine("Nhập vào số thứ 2: ");
            var tmp2 = Console.ReadLine();
            bool b2 = int.TryParse(tmp2, out num2);

            while (!(b1 && b2))
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                Console.WriteLine("Nhập vào số thứ 1: ");
                b1 = int.TryParse(Console.ReadLine(), out num1);
                Console.WriteLine("Nhập vào số thứ 2: ");
                b2 = int.TryParse(Console.ReadLine(), out num2);
            }

            while (num2 == 0)
            {
                Console.WriteLine("Số chia phải khác 0, hãy nhập lại");
                var b3 = int.TryParse(Console.ReadLine(), out num2);
                while (!b3)
                {
                    Console.WriteLine("Nhập vào 1 số khác 0");
                    b3 = int.TryParse(Console.ReadLine(), out num2);
                }
            }

            Console.WriteLine($"{num1} chia cho {num2} bằng " + num1 / num2 + " dư " + num1 % num2);
        }

        public void int5()
        {
            Console.WriteLine("Nhập vào số: ");
            int number;
            bool b = int.TryParse(Console.ReadLine(), out number);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = int.TryParse(Console.ReadLine(), out number);
            }
            if (number <= 0)
            {
                Console.WriteLine("Số <= 0");
            }
            else if (number < 2)
            {
                Console.WriteLine("Không phải số nguyên tố");
            }
            else
            {
                int count = 0;
                for (int i = 2; i < Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine("là số nguyên tố");
                }
                else
                {
                    Console.WriteLine("Không phải số nguyên tố");
                }
            }
        }

        public void int6(string str)
        {
            bool b = int.TryParse(str, out int num);
            if (b)
            {
                Console.WriteLine("Chuỗi số");
            }
            else
            {
                Console.WriteLine("Không phải chuỗi số");
            }
        }
    }
}
