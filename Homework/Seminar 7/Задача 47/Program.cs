// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
Console.WriteLine("Ведите число строк в массиве");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число столбцов в массиве");
int n = Convert.ToInt32(Console.ReadLine());
double[,] array = new double[m, n];

Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        array[i, j] = rnd.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
        Console.Write("{0,6:F}", array[i, j]);
    }
    Console.WriteLine();
}
