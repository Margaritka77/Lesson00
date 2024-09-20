using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите фамилию:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введите имя:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введите отчество");
            string thirdName = Console.ReadLine();
            Console.WriteLine(firstName+""+lastName+" "+thirdName);
        }
    }
}
