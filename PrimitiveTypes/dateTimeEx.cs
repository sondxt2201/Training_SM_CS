using System;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

namespace TrainingSkeleton_SonDXT.PrimitiveTypes
{
    internal class dateTimeEx
    {
        public void dateTime1()
        {
            DateTime date = DateTime.Now;
            Console.WriteLine("Hôm nay là thứ " + date.DayOfWeek + ", ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year);
        }

        public void dateTime2()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }
            Console.WriteLine("Chuỗi vừa nhập là thứ " + timeResult.DayOfWeek + ", ngày " + timeResult.Day + ", tháng " + timeResult.Month + ", năm " + timeResult.Year);
        }

        public void dateTime3()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }
            DateTime date = timeResult.AddDays(1);
            Console.WriteLine("Ngày hôm sau là thứ " + date.DayOfWeek + ", ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year);

        }

        public void dateTime4()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }
            DateTime date = timeResult.AddDays(-1);
            Console.WriteLine("Ngày hôm trước là thứ " + date.DayOfWeek + ", ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year);

        }

        public void dateTime5()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }

            if (timeResult == DateTime.Now.Date)
            {
                Console.WriteLine("Ngày hôm nay");
            }
            else if (timeResult > DateTime.Now)
            {
                Console.WriteLine("Ngày tương lai");
            }
            else
            {
                Console.WriteLine("Ngày quá khứ");
            }

        }

        public void dateTime6()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }

            Console.WriteLine("Ngày/tháng/năm: " + timeResult.Day + "/" + timeResult.Month + "/" + timeResult.Year);
            Console.WriteLine("Năm/tháng/ngày: " + timeResult.Year + "/" + timeResult.Month + "/" + timeResult.Day);
            Console.WriteLine("Tháng/năm: " + timeResult.Month + "/" + timeResult.Year);
            Console.WriteLine("Tháng-năm: " + timeResult.Month + "-" + timeResult.Year);

        }

        public void dateTime7()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }
            DateTime date = timeResult.AddDays(-10);
            Console.WriteLine("10 ngày trước là thứ " + date.DayOfWeek + ", ngày " + date.Day + ", tháng " + date.Month + ", năm " + date.Year);

        }

        public void dateTime8()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }

            DateTime lastDayOfMonth = new DateTime(timeResult.Year, timeResult.Month, DateTime.DaysInMonth(timeResult.Year, timeResult.Month));
            Console.WriteLine("Ngày cuối cùng của tháng là thứ " + lastDayOfMonth.DayOfWeek + ", ngày " + lastDayOfMonth.ToShortDateString());

        }

        public void dateTime9()
        {
            string str;
            DateTime timeResult;

            Console.WriteLine("Nhập vào chuỗi theo định dạng ngày/tháng/năm: ");
            str = Console.ReadLine();
            bool b = DateTime.TryParse(str, out timeResult);
            while (!b)
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                b = DateTime.TryParse(Console.ReadLine(), out timeResult);
            }
            DateTime lastDayOfYear = new DateTime(timeResult.Year, 12, 31);
            Console.WriteLine("Ngày cuối cùng của năm là thứ " + lastDayOfYear.DayOfWeek + ", ngày " + lastDayOfYear.ToShortDateString());

        }

        public void dateTime10()
        {
            //string str1, str2;
            DateTime timeResult1;
            DateTime timeResult2;

            Console.WriteLine("Nhập vào ngày thứ 1:");
            //var str1 = Console.ReadLine();
            bool b1 = DateTime.TryParse(Console.ReadLine(), out timeResult1);

            Console.WriteLine("Nhập vào ngày thứ 2:");
            //var str2 = Console.ReadLine();
            bool b2 = DateTime.TryParse(Console.ReadLine(), out timeResult2);

            while (!(b1 && b2))
            {
                Console.WriteLine("Dữ liệu nhập vào không đúng định dạng, hãy nhập lại");
                Console.WriteLine("Nhập vào ngày thứ 1:");
                b1 = DateTime.TryParse(Console.ReadLine(), out timeResult1);

                Console.WriteLine("Nhập vào ngày thứ 2:");
                b2 = DateTime.TryParse(Console.ReadLine(), out timeResult2);
            }
            TimeSpan diffDay = timeResult2 - timeResult1;
            Console.WriteLine("Khoảng cách giữa 2 ngày vừa nhập là: " + diffDay.Days);
        }
    }
}

