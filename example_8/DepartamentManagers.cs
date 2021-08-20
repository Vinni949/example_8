using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

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
        public int DeletedByTitle(string title)
        {
            
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
        /// <summary>
        /// удаление сотрудника
        /// </summary>
        /// <param name="name"></param>
        public void DeletedByWorker(string name)
        {
            
            for (int i = 0; i < departaments.Count; i++)
            {
                departaments[i].DeletedByName(name);
            }
        }
        /// <summary>
        /// вывод всех сотрудников
        /// </summary>
        /// <returns></returns>
        public string PrintWorker()
        {
            string text = string.Empty;
            foreach (Departament dep in departaments)
            {
                text+="\n"+dep.PrintWorker();
            }
            return text;
        }
        /// <summary>
        /// вывод всех департаментов
        /// </summary>
        /// <returns></returns>
        public string PrintDepartament()
        {
            string text = string.Empty;
            foreach (Departament dep in departaments)
            {
                text +=dep.PrintDepartament();
            }
            return text;
        }
        /// <summary>
        /// сортировка сотрудника по именни в заданном департаменте
        /// </summary>
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
        /// <summary>
        /// удаление департамента по названию
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int AddWorkerByTitle(string title, int number, string name, string firstName, int age, int salary, int progectCount)
        {
            
            int count = 0;
            for (int i = 0; i < departaments.Count; i++)
            {
                if (departaments[i].Title == title)
                {
                    departaments[i].AddWorker(number,name,firstName,age,title,salary,progectCount);
                }
            }
            return count;
        }

        /// <summary>
        /// Сериализация
        /// </summary>
        public void Serialize()
        {
            using(StreamWriter file=new StreamWriter ("Data.json"))
            {
                string json = JsonConvert.SerializeObject(departaments);
                file.Write(json);
            }
        }
        /// <summary>
        /// Десериализация
        /// Получение данных из файла
        /// </summary>
        public void DeSerialize()
        {
            using (StreamReader file = new StreamReader("Data.json"))
            {
                string json;
                json=file.ReadToEnd();
                departaments=JsonConvert.DeserializeObject<List<Departament>>(json);
            }
        }
    }
}
