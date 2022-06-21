using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{

    public class student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string dept { get; set; }

    }
    public class Program
    {
        public void show()
        {
            List<student> list = new List<student>()
         {
             new student (){ id = 1, name ="Dipakshi", age=22, dept="IT"},
             new student (){ id = 1, name = "Shatakshi", age=23, dept="IT"},
             new student (){ id = 1, name = "Aditya", age=22, dept="IT"},
             new student (){ id = 1, name = "Ayush", age=21, dept="CSE"},
             new student (){ id = 1, name = "Akshat", age=23, dept="IT"},
             new student (){ id = 1, name = "Prashant", age=21, dept="Civil"},

         };
            var result = (from l in list
                          where l.dept == "IT"
                          select l);
            foreach (var item in result)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.name);
                Console.WriteLine(item.age);
                Console.WriteLine(item.dept);

            }
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.show();
        }
    }
}