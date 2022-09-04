// Задача 64: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> "1, 2, 3, 4, 5"
// M = 4; N = 8. -> "4, 6, 7, 8"

// Console.Clear();
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// PrintNumbers(m,n);

// void PrintNumbers(int start, int end)
// {
// Console.Write($"{start}");
// if (start == end) return;
// PrintNumbers(start + 1, end);
// }



// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Clear();
// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// void SumArray (int m, int n, int sum)
// {
//     if (m > n) 
//     {
//         Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
//         return;
//     }
//     sum = sum + (m++);
//     SumArray(m, n, sum);
// }
// SumArray(m, n, 0);



// // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// // Даны два неотрицательных числа m и n. 
// // m = 2, n = 3 -> A(m,n) = 29

// Console.Clear();
// int m = InputNumbers("Введите m: ");
// int n = InputNumbers("Введите n: ");

// int functionAkkerman = Ack(m, n);
// Console.Write($"Функция Аккермана = {functionAkkerman} ");

// int Ack(int m, int n)
// {
//   if (m == 0) return n + 1;
//   else if (n == 0) return Ack(m - 1, 1);
//   else return Ack(m - 1, Ack(m, n - 1));
// }
// int InputNumbers(string input) 
// {
//   Console.Write(input);
//   int output = Convert.ToInt32(Console.ReadLine());
//   return output;
// }