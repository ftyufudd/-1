//// задание 1
//Console.Write("Размер массива: ");
//int n;
//while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
//{
//    Console.Write("Ошибка. Введите целое неотрицательное число: ");
//}
//
//int[] arr = new int[n];
//
//var rnd = new Random();
//for (int i = 0; i < n; i++) arr[i] = rnd.Next(0, 100);
//
//Console.WriteLine("Массив: " + string.Join(", ", arr));
// 
//2 задание

//      Console.Write("Размер массива: ");
//      if (!int.TryParse(Console.ReadLine(), out int n) || n < 0)
//      {
//          Console.WriteLine("Неверный размер.");
//          return;
//      }
//
//      int[] arr = new int[n];
//
//      for (int k = 0; k < n; k++)
//      {
//          int pos = (k % 2 == 0) ? n - 1 - (k / 2) : (k / 2);
//          arr[pos] = k + 1; // записываем числа 1..n в порядке ввода
//      }
//
//      Console.WriteLine("Массив в правильном порядке: " + string.Join(", ", arr));
//
//3 задание
//const int N = 10;
//int[,] a = new int[N, N];
//var rnd = new Random();
//
//long[] rowSums = new long[N];
//long[] colProds = new long[N];
//for (int j = 0; j < N; j++) colProds[j] = 1;
//for (int i = 0; i < N; i++)
//{
//    for (int j = 0; j < N; j++)
//    {
//        a[i, j] = rnd.Next(1, 10); // 1..9
//        rowSums[i] += a[i, j];
//        colProds[j] *= a[i, j];
//    }
//}
//Console.WriteLine("Матрица 10x10:");
//for (int i = 0; i < N; i++)
//{
//    for (int j = 0; j < N; j++)
//        Console.Write(a[i, j] + " ");
//    Console.WriteLine();
//}
//int maxRow = 0;
//for (int i = 1; i < N; i++)
//    if (rowSums[i] > rowSums[maxRow]) maxRow = i;
//
//int maxCol = 0;
//for (int j = 1; j < N; j++)
//    if (colProds[j] > colProds[maxCol]) maxCol = j;
//
//Console.WriteLine($"\nМаксимальная сумма строки: {rowSums[maxRow]} (строка {maxRow})");
//Console.WriteLine($"Максимальное произведение столбца: {colProds[maxCol]} (столбец {maxCol})");
//