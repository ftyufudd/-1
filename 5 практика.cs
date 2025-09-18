//        Console.Write("Введите число: ");
//        int n = int.Parse(Console.ReadLine());
//
//        while (n < 6)
//        {
//            Console.WriteLine("n = " + n);
//            n++;
//        }
//
//
//    Console.Write("Введите число: ");
//    int n = int.Parse(Console.ReadLine());
//    do
//    {
//    Console.WriteLine("n = " + n);
//    n++;
//    }
//    while (n < 6);
//    
/////////

//        Console.Write("Введите число: ");
//        int i = int.Parse(Console.ReadLine());
//
//        int value = 1;
//        while (value <= i)
//        {
//            Console.Write(value + " ");
//            value *= 2;
//        }
////////

//       Console.Write("Введите кол-во чисел Фибоначчи: ");
//       int n = int.Parse(Console.ReadLine());
//
//       if (n <= 0)
//       {
//           Console.WriteLine("Введите положительное число");
//           return;
//       }
//
//       int a = 0, b = 1;
//
//       for (int i = 0; i < n; i++)
//       {
//           Console.Write(a + " ");
//           int temp = a + b;
//           a = b;
//           b = temp;
//       }
//