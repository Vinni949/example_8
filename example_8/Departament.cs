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

        int Number;
        public DateTime Date { get; set; }

        public int count { get; set; }

        public Departament(string title, string date)
        {
            this.Title = title;
            this.Date = DateTime.Parse(date);
            count = 0;
            Number = 0;
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
            number++;
            Worker worker = new Worker(number,name,firstName,age, departament, salary,progectCount);
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
        public string PrintWorker()
        {
            string text = string.Empty;
            foreach (Worker worker in workers)
            {
                text +=worker.Print();
            }
            return text;
        }
        
        /// <summary>
        /// Сортировка по имени
        /// </summary>
        public void SortByName()
        {
            workers.Sort((a, b) => a.Name.CompareTo(b.Name));
            PrintWorker();
        }
        /// <summary>
        /// сортировка по фамилии
        /// </summary>
        public void SortByFirstName()
        {
            workers.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
            PrintWorker();
        }
        public string PrintDepartament()
        {
            return $"\t{"Название департамента: " + Title + "\tДата создания: " + Date}\n";
        }
    }
}
