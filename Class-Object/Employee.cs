using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton_SonDXT.Class_Object
{
    internal class Employee
    {
        //field
        private string _name;
        private int _age;
        private DateTime _date;

        //properties
        public string Name { get { return _name; } set { _name = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public DateTime Date { get { return _date; } set { _date = value; } }

        //default constructor
        public Employee() { }

        //methods
        public void ShowInfo()
        {
            Console.WriteLine("Tôi tên là: " + Name + ", tuối: " + Age);
        }

        public void ExtInfo()
        {
            Console.WriteLine("Tôi tên là: " + Name + ", được tạo ra lúc: " + Date);
        }
    }
}
