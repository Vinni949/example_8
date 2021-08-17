using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_8
{
    class ConsolePrinter : IPrinter
    {
        /// <summary>
        /// класс печати на консоль
        /// </summary>
        /// <param name="text"></param>
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
