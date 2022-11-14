using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton_SonDXT.Class_Object
{
    internal class Student : Employee
    {
        //field
        private string _specialized;

        //properties
        public string Specialized { get { return _specialized; } set { _specialized = value; } }

        //constructor
        public Student() : base() { }

        //methods
        new public void ShowInfo()
        {
            Console.WriteLine("Tôi là Sinh viên, " + Age + " tuối, tôi tên là " + Name);
        }

        new public void ExtInfo()
        {
            Console.WriteLine("Tôi là Sinh viên tên " + Name + ", học chuyên ngành " + Specialized + ", được tạo ra lúc: " + Date);
        }
    }
}
