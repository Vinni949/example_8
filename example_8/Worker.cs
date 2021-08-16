using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_8
{
    class Worker
    {
        public int Number { get; set; }

        public string Name { get; set; }

        public string FirstName { get; set; }

        public int Age { get; set; }

        public string Departament { get; set; }

        public int Salary { get; set; }

        public int ProgectCount { get; set; }

        public Worker(int number, string name,string firstName,int age,string departament,int salary,int progectCount)
        {
            this.Number = number;
            this.Name = name;
            this.FirstName = firstName;
            this.Age = age;
            this.Departament = departament;
            this.Salary = salary;
            this.ProgectCount = progectCount;
        }


    }
}
