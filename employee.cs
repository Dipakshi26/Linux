using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinuxhandsOn
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string dept { get; set; }

    }
    internal class employeedetails
    {
        public void emp()
        {
            List<employee> list = new List<employee>()
         {
             new employee (){ id = 1, name = "Dipakshi", age=22, dept="IT"},
             new employee (){ id = 1, name = "Shatakshi", age=23, dept="IT"},
             new employee (){ id = 1, name = "Aditya", age=22, dept="IT"},
             new employee (){ id = 1, name = "Ayush", age=21, dept="CSE"},
             new employee (){ id = 1, name = "Akshat", age=23, dept="IT"},
             new employee (){ id = 1, name = "Prashant", age=21, dept="Civil"},

         };
            var result1 = (from e in list
                           where e.dept == "IT"
                           select e).Single();
            Console.WriteLine(result1);

        }
    }
}