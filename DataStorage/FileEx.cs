using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton_SonDXT.DataStorage
{
    internal class FileEx
    {
        public string filePath1 { get; set; }
        public string filePath2 { get; set; }

        public void DataStorage()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            try
            {
                FileStream f1 = new FileStream(filePath1, FileMode.Open);
                StreamReader s1 = new StreamReader(f1);

                FileStream f2 = new FileStream(filePath2, FileMode.Open);
                StreamWriter s2 = new StreamWriter(f2);

                string line = "";
                string line2 = "";

                try
                {
                    while ((line = s1.ReadLine()) != null)
                    {
                        line = string.Join(",", line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

                        int[] arr = line.Split(',').Select(int.Parse).ToArray();
                        Array.Sort(arr);
                        Array.Reverse(arr);

                        line2 = string.Join("    ", arr);
                        s2.WriteLine(line2);
                    }
                    Console.WriteLine("Ghi dữ liệu thành công!");
                    s1.Close();
                    s2.Close();
                    f1.Close();
                    f2.Close();
                }
                catch (OverflowException ove)
                {
                    Console.WriteLine($"\nDòng \'{line}\' có số bị vượt giới hạn kiểu Int32 \n" + ove);
                }
                catch (FormatException fme)
                {
                    Console.WriteLine($"\nDòng \'{line}\' có số bị sai format \n" + fme);
                }
            }
            catch (IOException ioe)
            {
                Console.WriteLine("\nKhông đọc được file đầu vào. \nLý do:" + ioe);
            }

        }
    }
}
