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
        /// <summary>
        /// добавление сотрудника в департамент
        /// </summary>
        /// <param name="number"></param>
        /// <param name="name"></param>
        /// <param name="firstName"></param>
        /// <param name="age"></param>
        /// <param name="departament"></param>
        /// <param name="salary"></param>
        /// <param name="progectCount"></param>
        public void AddWorker(int number,string name,string firstName,int age,string departament,int salary,int progectCount)
        {
            Worker worker = new Worker(number,name,firstName,age,departament,salary,progectCount);
            workers.Add(worker);
        }
        /// <summary>
        /// удаление сотрудника по номеру
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int DeletedByNumber(int number)
        {
            int count = 0;
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Number == number)
                {
                    workers.RemoveAt(i);
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// удаление сотрудника по имени
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int DeletedByName(string name)
        {
            int count = 0;
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Name == name)
                {
                    workers.RemoveAt(i);
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// удаление сотрудника по фамилии
        /// </summary>
        /// <param name="firstName"></param>
        /// <returns></returns>
        public int DeletedByFirstName(string firstName)
        {
            int count = 0;
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].FirstName == firstName)
                {
                    workers.RemoveAt(i);
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// Печать всех сотрудников
        /// </summary>
        public void Print()
        {
            foreach (Worker task in workers)
            {
                task.Print(new ConsolePrinter());
                Console.WriteLine();
            }
        }
    }
}
