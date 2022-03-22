//Показать таблицу квадратов чисел от 1 до N
Console.WriteLine("введите число");

int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    Console.WriteLine($"квадрат числа {i} =" + Math.Pow(i, 3));
}
// using System;

// namespace My3
// {
//      class Program
//      {
//           static void Main(string[] args)
//           {
//                double x = 0.5;
//                int stepen = 4;
//                Console.WriteLine("0.5^4 = " + Math.Pow(x, stepen));
//                Console.WriteLine("5^4 = " + Math.Pow(5, 4));
//                Console.WriteLine("-5^4 = " + Math.Pow(-5, 4));
//                Console.WriteLine("-5^(-4) = " + Math.Pow(-5, -4));
//                Console.ReadKey();
//           }
//      }
// }