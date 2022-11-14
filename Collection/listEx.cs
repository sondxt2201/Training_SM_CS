using System;
using System.Text;


namespace TrainingSkeleton_SonDXT.Collection
{
    internal class listEx
    {
        public void list1()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("Các phần tử vừa thêm vào list là: ");
            foreach (var i in list)
            {
                Console.WriteLine(i);
            }
        }

        public void list2()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }
            list.Sort();
            Console.WriteLine("Các phần tử vừa thêm vào list sau khi được sắp xếp là: ");
            foreach (var i in list)
            {
                Console.Write(i + ",");
            }
        }

        public void list3()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            list.Reverse();
            Console.WriteLine("Các phần tử vừa thêm vào list sau khi được đảo ngược lại là: ");
            foreach (var i in list)
            {
                Console.Write(i + ",");
            }
        }

        //Bỏ đi các phần tử nhỏ hơn X
        public void list4()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Nhập vào số X:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= list.Count; i++)
            {
                if (list[i] < num)
                {
                    list.Remove(list[i]);
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("List đã bị xóa hết");
            }
            else
            {
                Console.WriteLine("Các phần tử còn lại trong list là: ");
                foreach (var i in list)
                {
                    Console.Write(i + ",");
                }
            }
        }

        //Bỏ đi các phần tử chia hết cho X
        public void list5()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Nhập vào số X:");
            int num = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < list.Count; i++)
            {
                if ((list[i] % num) == 0)
                {
                    list.Remove(list[i]);
                }
            }
            if (list.Count == 0)
            {
                Console.WriteLine("List đã bị xóa hết");
            }
            else
            {
                Console.WriteLine("Các phần tử còn lại trong list là: ");
                foreach (var i in list)
                {
                    Console.Write(i + ",");
                }
            }
        }


        public void list6()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Nhập vào số X:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] < num)
                {
                    list[i] += num;
                }
            }

            Console.WriteLine("Các phần tử trong list sau khi thay đổi là: ");
            foreach (var i in list)
            {
                Console.Write(i + ",");
            }
        }


        public void list7()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Nhập vào số X:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num} phần tử cuối của list là: ");

            for (int i = list.Count - num + 1; i <= list.Count; i++)
            {                
                Console.Write(i + ",");
            }
        }

        public void list8()
        {
            Console.WriteLine("Nhập vào số lượng phần tử:");
            int count = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Nhập các phần tử:");
            var list = new List<int>();
            for (var i = 0; i < count; i++)
            {
                list.Add(Convert.ToInt32(Console.ReadLine()));
            }

            Console.WriteLine("Nhập vào số X:");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"{num} phần tử cuối của list theo chiều ngược lại là: ");

            for (int i = list.Count; i >= list.Count -num + 1; i--)
            {
                Console.Write(i + ",");
            }
        }

        public void list9()
        {
            Console.WriteLine("Nhập vào số lượng phần tử của dãy Fibonaci:");
            int count = Convert.ToInt32(Console.ReadLine());
            int prv = 0, pre = 1, next;

            var list = new List<int>(count);
            list.Add(prv);
            list.Add(pre);

            Console.Write($"Dãy Fibonacci gồm {count} phần tử là: ");
            for (var i = 3; i <= count; i++)
            {
                next = prv + pre;
                prv = pre;
                pre = next;
                list.Add(next);
            }

            foreach (var item in list)
            {
                Console.Write(item + ",");
            }
        }
    }
}