using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_8
{
    class Departament
    {
        List<Worker> workers = new List<Worker>();
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Departament(string title, string date)
        {
            this.Title = title;
            this.Date = DateTime.Parse(date);
        }

        public void AddWorker(int number,string name,string firstName,int age,string departament,int salary,int progectCount)
        {
            Worker worker = new Worker(number,name,firstName,age,departament,salary,progectCount);
            workers.Add(worker);
        }
    }
}
