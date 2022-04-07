// ЗАДАЧА 36. Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечётных позициях.
using System;
int[] array = new int[15];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(50);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int sumOddNumbers = 0;
for(int i = 1; i < array.Length; i+=2)
{
    sumOddNumbers = sumOddNumbers + array[i];
}
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOddNumbers}");