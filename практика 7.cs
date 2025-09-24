//Console.WriteLine("Введите строку: ");
//string str1 = Console.ReadLine();
//Console.WriteLine("Введите разделительный символ: ");
//char symbolrazdel = Console.ReadKey().KeyChar;
//Console.WriteLine();
//
//string[] parts = str1.Split(symbolrazdel);
//
//Console.Write("Итоговая строка: ");
//foreach (string part in parts)
//{
//    Console.Write(part + " ");
//}
//  
//    {
//        string s = "абв абВ аБв";
//        char target = 'а';
//        var (count, result) = CountAndUpper(s, target);
//        Console.WriteLine(count);   
//        Console.WriteLine(result);  
//    }
//
//    static (int, string) CountAndUpper(string input, char target)
//    {
//        if (string.IsNullOrEmpty(input)) return (0, input);
//        var sb = new StringBuilder(input.Length);
//        int cnt = 0;
//        foreach (char c in input)
//        {
//            if (c == target)
//            {
//                cnt++;
//                sb.Append(char.ToUpper(c)); 
//            }
//            else
//            {
//                sb.Append(c);
//            }
//        }
//        return (cnt, sb.ToString());
//    }
//

//
//using System.Text;
//
//string alphabet = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
//
//string CaesarCipher(string text, int shift)
//{
//    StringBuilder res = new StringBuilder();
//
//    foreach (char c in text.ToLower())
//    {
//        int charIndex = alphabet.IndexOf(c);
//
//        if (charIndex != -1)
//        {
//            int newIndex = (charIndex + shift) % alphabet.Length;
//            if (newIndex < 0)
//            {
//                newIndex += alphabet.Length;
//            }
//            res.Append(alphabet[newIndex]);
//        }
//        else
//        {
//            res.Append(c);
//        }
//    }
//    return res.ToString();
//}
//
//Console.WriteLine("Слово для шифрования: ");
//string word = Console.ReadLine();
//
//Console.WriteLine("Сдвиг символа на: ");
//int shiftAmount = int.Parse(Console.ReadLine());
//
//string encryptedWord = CaesarCipher(word, shiftAmount);
//Console.WriteLine($"Зашифрованное слово: {encryptedWord}");
//
//string decryptedWord = CaesarCipher(encryptedWord, -shiftAmount);
//Console.WriteLine($"Дешифрованное слово: {decryptedWord}");