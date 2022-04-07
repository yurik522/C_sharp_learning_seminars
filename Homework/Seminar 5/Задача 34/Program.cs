// ЗАДАЧА 34. Задайте массив, заполненный случайными положительными
//трехзначными числами. Напишите программу, которая покажет количество
//четных числеа в массиве.
void FillArray(int[] collection)
{
    int length = collection.Length;
    for (int index =0; index < length; index++)
    {
        collection[index] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] col) 
{   int length = col.Length;
       for (int index =0; index < length; index++)
    {
       Console.Write($"{col[index]}, ");
    }
}
int[] array = new int[15];
FillArray(array);
PrintArray(array);
Console.WriteLine();
int length = array.Length;
int count = 0;
for(int i = 0; i < length; i++)
{
    if (array[i] % 2 == 0)
    count++;
}
Console.WriteLine($"Количество чётных чисел в массиве = {count}");


