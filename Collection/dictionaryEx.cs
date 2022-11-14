using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton_SonDXT.Collection
{
    internal class dictionaryEx
    {
        public void dict1()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào mã SV và tên SV:");
            var dict = new Dictionary<int, string>();
            for (var i = 0; i < count; i++)
            {
                dict.Add(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }
            Console.WriteLine("Các phần tử vừa thêm vào là: ");
            foreach (var i in dict)
            {
                Console.WriteLine(i);
            }
        }

        public void dict2()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào mã SV và tên SV:");
            var dict = new Dictionary<int, string>();
            for (var i = 0; i < count; i++)
            {
                dict.Add(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }

            Console.WriteLine("Nhập vào mã SV cần kiểm tra:");
            int ID = Convert.ToInt32(Console.ReadLine());

            if (dict.ContainsKey(ID))
            {
                Console.WriteLine("Mã SV đã tồn tại");
                Console.WriteLine($"SV có mã {ID} là: " + dict.Values.ElementAt(ID));
            }
            else
            {
                Console.WriteLine($"Không có SV có mã là {ID}");
            }
        }

        public void dict3()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào mã SV và tên SV:");
            var dict = new Dictionary<int, string>();
            for (var i = 0; i < count; i++)
            {
                dict.Add(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }

            Console.WriteLine("Nhập vào mã và tên SV cần kiểm tra:");
            int ID = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();

            if (dict.ContainsKey(ID))
            {
                Console.WriteLine($"Đã có SV có mã {ID} trong Dictionary");
            }
            else
            {
                Console.WriteLine($"Sinh viên có mã {ID} và tên {name} chưa có trong Dictionary");
                dict.Add(ID, name);
                Console.WriteLine($"Đã thêm sinh viên có mã {ID} và tên {name} vào Dictionary");
                Console.WriteLine("Các sinh viên hiện có trong Dictionary là:");
                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }
            }

        }

        public void dict4()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào mã SV và tên SV:");
            var dict = new Dictionary<int, string>();
            for (var i = 0; i < count; i++)
            {
                dict.Add(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }

            Console.WriteLine("Nhập vào mã và tên SV cần kiểm tra:");
            int ID = Convert.ToInt32(Console.ReadLine());
            string name = Console.ReadLine();

            if (dict.ContainsKey(ID))
            {
                Console.WriteLine($"Đã thay tên SV có mã {ID} trong Dictionary từ " + dict.Values.ElementAt(ID - 1) + $" thành {name}");
                dict[ID] = name;

                Console.WriteLine("Các sinh viên hiện có trong Dictionary là:");
                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Sinh viên có mã {ID} và tên {name} chưa có trong Dictionary");
                dict.Add(ID, name);
                Console.WriteLine($"Đã thêm sinh viên có mã {ID} và tên {name} vào Dictionary");
                Console.WriteLine("Các sinh viên hiện có trong Dictionary là:");
                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }
            }

        }

        public void dict5()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập vào mã SV và tên SV:");
            var dict = new Dictionary<int, string>();
            for (var i = 0; i < count; i++)
            {
                dict.Add(Convert.ToInt32(Console.ReadLine()), Console.ReadLine());
            }

            Console.WriteLine("Nhập vào mã SV cần xóa bỏ:");
            int ID = Convert.ToInt32(Console.ReadLine());
            //string name = Console.ReadLine();

            if (dict.ContainsKey(ID))
            {
                Console.WriteLine($"Đã loại bỏ SV có mã {ID} khỏi Dictionary");
                dict.Remove(ID);

                Console.WriteLine("Các sinh viên hiện có trong Dictionary là:");
                foreach (var item in dict)
                {
                    Console.WriteLine(item);
                }
            }
        }

    }
}
