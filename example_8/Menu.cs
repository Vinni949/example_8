using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace example_8
{

    class Menu
    {
        static DepartamentManagers departamentManagers = new DepartamentManagers();
        public void Show()
        {
            if (!(File.Exists("Data.json"))) 
            {
                departamentManagers.Serialize();
            }
            departamentManagers.DeSerialize();
            bool choice = true;
            while (choice)
            {
                string text = string.Empty;
                Console.WriteLine();
                Console.WriteLine("Введите номер: \n1-Печатать все департаменты, \n2-Печатать всех работников, \n3-Удалить департамент, " +
                    "\n4-Удалить сотрудника, \n5-Упорядочить записи сотрудников,\n6-добавить департамент,\n7-добавить сотрудника \n0 - exit");
                switch (Console.ReadKey().Key)
                {
                    
                    case ConsoleKey.D1:
                        Console.WriteLine();
                        Console.WriteLine(departamentManagers.PrintDepartament());
                        break;
                    case ConsoleKey.D2:
                        Console.WriteLine(departamentManagers.PrintWorker());
                        break;
                    case ConsoleKey.D3:
                        Console.WriteLine();
                        text = Console.ReadLine();
                        departamentManagers.DeletedByTitle(text);
                        departamentManagers.Serialize();
                        break;
                    case ConsoleKey.D4:
                        Console.WriteLine();
                        departamentManagers.DeletedByWorker(text);
                        departamentManagers.Serialize();
                        break;
                    case ConsoleKey.D5:
                        Console.WriteLine();
                        departamentManagers.SortWorker();
                        break;
                    case ConsoleKey.D6:
                        Console.WriteLine();
                        Console.WriteLine("Введите название департамента:");
                        text = Console.ReadLine();
                        departamentManagers.AddDepartament(text, DateTime.Now.ToString());
                        departamentManagers.Serialize();
                        break;
                    case ConsoleKey.D7:
                        Console.WriteLine();
                        Console.WriteLine("Добавление сотрудника:");
                        Console.WriteLine("Введите название департамента в который добавить сотрудника:");
                        string title = Console.ReadLine(); 
                        Console.WriteLine("Введите табельный номер:");
                        int number;
                        if (int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Введите имя:");
                            string name = Console.ReadLine();
                            Console.WriteLine("Введите фамилию:");
                            string firstName = Console.ReadLine();
                            Console.WriteLine("Введите возраст:");
                            int age;
                            if (int.TryParse(Console.ReadLine(), out age))
                            {
                                Console.WriteLine("Введите заработную плату:");
                                int salary ;
                                if (int.TryParse(Console.ReadLine(), out salary))
                                {
                                    Console.WriteLine("Введите количество проэктов которое ведет сотрудник:");
                                    int progectCount;
                                    if (int.TryParse(Console.ReadLine(), out progectCount))
                                    {
                                        departamentManagers.AddWorkerByTitle(title, number, name, firstName, age, salary, progectCount);
                                        departamentManagers.Serialize();
                                        Console.WriteLine("Запись успешно выполнена!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Введено не верное значение!");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Введено не верное значение!");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Введено не верное значение!");
                            }
                        }
                        else
                        { 
                            Console.WriteLine("Введено не верное значение!");
                        }
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
    
