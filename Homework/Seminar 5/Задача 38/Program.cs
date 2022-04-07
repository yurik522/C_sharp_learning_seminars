// ЗАДАЧА 38. Задайте массив вещественных чисел. Найдите разницу между
//максимальным и минимальным элемнтами массива.
int  minNumberSearch(int[] collection)
{   
    int minNumber = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
       if (collection[i] < minNumber) minNumber = collection[i];
    }
    return minNumber;
}
int  maxNumberSearch(int[] collection)
{   
    int maxNumber = collection[0];
    for (int i = 0; i < collection.Length; i++)
    {
       if (collection[i] > maxNumber) maxNumber = collection[i];
    }
    return maxNumber;
}
Console.WriteLine("Сгенерированный массив");
 int[] array = new int[15];
Random rand = new Random();
for(int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-50, 50);
    Console.Write($"{array[i]}, ");
}
int minNum = minNumberSearch(array);
int maxNum = maxNumberSearch(array);
Console.WriteLine();
Console.WriteLine("Минимальное число в массиве: {0} , Максимальное число в массиве: {1}", minNum, maxNum);
Console.WriteLine($"Разница между максимальным и минимальным числом в массиве = {maxNum - minNum}");




// int  minNumberMethod(int[] collection)
// {   
//     int length = collection.Length;
//     int minNumber = collection[0];
//     for (int i = 0; i < length; i++)
//     {
//        if (collection[i] < minNumber) minNumber = collection[i];
//     }
//     return minNumber;
// }
//  int[] array = new int[15];
// Random rand = new Random();
// for(int i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-50, 50);
//     Console.Write($"{array[i]}, ");
// }

//  int minNum = minNumberMethod(array);
// Console.WriteLine("Минимальное число в массиве: {0}", minNum);