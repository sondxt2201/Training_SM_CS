using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingSkeleton_SonDXT.Class_Object
{
    internal class Teacher : Employee
    {
        //field
        private string _subject;

        //properties
        public string Subject { get { return _subject; } set { _subject = value; } }

        //constructor
        public Teacher() :base() { }

        //methods
         new public void ShowInfo()
        {
            Console.WriteLine("Tôi là Giáo viên, " + Age + " tuối, tôi tên là " + Name);
        }

         new public void ExtInfo()
        {
            Console.WriteLine("Tôi là Giáo viên tên " + Name + ", thuộc bộ môn " + Subject + ", được tạo ra lúc: " + Date);
        }
    }
}
