using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            //string input = Console.ReadLine();
            //int result =
            //Convert.ToInt32(input, 2);
            //Console.Write(result);

            //Задание 2
            Console.WriteLine();
            string input = Console.ReadLine();
            int number = int.Parse(input);
            string result = Convert.ToString(number, 2);
            Console.WriteLine(result);
        }
    }
}
