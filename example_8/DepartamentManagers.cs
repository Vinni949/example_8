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
        public void AddDepartament(string title,string date)
        {
            Departament dep = new Departament(title,date);
            departaments.Add(dep);
        }

        /// <summary>
        /// удаление департамента по названию
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public int DeletedByNumber(string title)
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
    }
}
