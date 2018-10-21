using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Консоль в режиме теста");
            Console.ReadKey();
            Console.Write("Введите ваше имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Привет " + name);
            Console.ReadKey();
        }
    }
}
