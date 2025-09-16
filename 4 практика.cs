//1 задание
// using System;
//using System.Text; 
//public class AlternatingCase
//{
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("Введите строку:");
//        string inputString = Console.ReadLine(); 
//
//        StringBuilder resultBuilder = new StringBuilder(); 
//
//        for (int i = 0; i < inputString.Length; i++)
//        {
//            char currentChar = inputString[i]; 
//
//            if (i % 2 == 0) 
//            {
//                resultBuilder.Append(char.ToUpper(currentChar));
//            }
//            else
//            {
//                resultBuilder.Append(char.ToLower(currentChar));
//            }
//        }
//
//        string alternatingCaseString = resultBuilder.ToString();
//
//        Console.WriteLine("Строка с измененным регистром:");
//        Console.WriteLine(alternatingCaseString); 
//    }
//}
//
//
//using System;
//using System.Collections.Generic;
//
// class Program
//{
//    static void Main()
//    {
//        Console.WriteLine("Введите число до 1000:");
//        int numbers;
//        while (true)
//        {
//            if (int.TryParse(Console.ReadLine(), out numbers))
//            {
//                if (numbers >= 0 && numbers <= 1000)
//                {
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Пожалуйста, введите число от 0 до 1000:");
//                }
//            }
//            else
//            {
//                Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
//            }
//        }
//
//        Console.WriteLine($"Числа от 0 до {numbers}:");
//        for (int i = 0; i <= numbers; i++)
//        {
//            Console.Write(i + " ");
//        }
//        Console.WriteLine();
//    }
//    }
//

//  Задание 3
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> list = new List<int>();
        Console.WriteLine("Введите 5 чисел:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"Введите число {i + 1}: ");
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int input))
                {
                    list.Add(input);
                    break;
                }
                else
                {
                    Console.WriteLine("Некорректный ввод. Попробуйте еще раз:");
                }
            }
        }

        Console.WriteLine("Элементы в обратном порядке:");
        for (int i = list.Count - 1; i >= 0; i--)
        {
            Console.Write(list[i] + " ");
        }
        Console.WriteLine();
    }
}


