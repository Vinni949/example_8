using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_8
{
    class DepartamentManagers
    {
        static List<Departament> departaments = new List<Departament>();
        /// <summary>
        /// Создание департамента
        /// </summary>
        /// <param name="title"></param>
        /// <param name="date"></param>
        public void AddDepartament(string title, string date)
        {
            Departament dep = new Departament(title, date);
            departaments.Add(dep);
        }

        /// <summary>
        /// удаление департамента по названию
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int DeletedByTitle()
        {
            string title = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < departaments.Count; i++)
            {
                if (departaments[i].Title == title)
                {
                    departaments.RemoveAt(i);
                    count++;
                }
            }
            return count;
        }

        public int DeletedByWorker()
        {
            string name = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < departaments.Count; i++)
            {
                departaments[i].DeletedByName(name);
            }
            return count;
        }

        public void PrintWorker()
        {
            foreach (Departament dep in departaments)
            {
                dep.PrintWorker();
                Console.WriteLine();
            }
        }

        public void PrintDepartament()
        {
            foreach (Departament dep in departaments)
            {
                dep.PrintDepartament(new ConsolePrinter());
                Console.WriteLine();
            }
        }
        public void SortWorker()
        {
            Console.WriteLine("Введите название департамента для сортировки сотрудников в нем:");
            string title = Console.ReadLine();
            for (int i = 0; i < departaments.Count(); i++)
            {
                if (departaments[i].Title == title)
                {
                    departaments[i].SortByName();
                }
            }
        }
    }
}
