using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_8
{

    class Menu
    {
        static DepartamentManagers departamentManagers = new DepartamentManagers();
        public void Show()
        {
            bool choice = true;
            while (choice)
            {
                Console.WriteLine();
                Console.WriteLine("Введите номер: \n1-Печатать все департаменты, \n2-Печатать всех работников, \n3-Удалить департамент, " +
                    "\n4-Удалить сотрудника, \n5-Упорядочить записи сотрудников,\n0 - exit");
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                        departamentManagers.PrintDepartament();
                        break;
                    case ConsoleKey.D2:
                        departamentManagers.PrintWorker();
                        break;
                    case ConsoleKey.D3:
                        departamentManagers.DeletedByTitle();
                        break;
                    case ConsoleKey.D4:
                        departamentManagers.DeletedByWorker(); ;
                        break;
                    case ConsoleKey.D5:
                        departamentManagers.SortWorker(); ;
                        break;
                    case ConsoleKey.D0:
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Нажата неверна клавиша, введите снова!");
                        break;
                }
            }
        }
    } 
}
    
