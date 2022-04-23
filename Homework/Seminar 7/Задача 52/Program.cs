// Задача 52: Задайте двумерный массив из целых чисел. Найдите
// среднее арифметическое элементов в каждом столбце.
void FillArray(int[,] newArray)
{
    Random rnd = new Random();
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = rnd.Next(-10, 10);
        }

    }
}
void PrintArray(int[,] newArray)
{
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write("{0,4}", newArray[i, j]);
        }
        Console.WriteLine();
    }
}
// void AverageColumns(int[,] newArray)    //РАБОТАЕТ ТОЛЬКО С КВАДРАТНЫМИ МАССИВАМИ.
// {
//     double sumColum = 0;
//     for(int i = 0; i < newArray.GetLength(0); i ++)
//     {
//         for(int j = 0; j < newArray.GetLength(0); j ++)
//         {
//             sumColum = sumColum + newArray[j, i];
//         }
//         double average = sumColum/(newArray.GetLength(0));
//         Console.Write($"Среднее арифмитеческое {i + 1} -го столбца равно ");
//         Console.Write("{0,6:F}", average);
//         sumColum = 0;
//         Console.WriteLine();
//     }
// }
void AverageColumns(int[,] newArray)
{   int j = 0;
    while (j < newArray.GetLength(1))
    {        
        double sumColum = 0;
        double average = 0;
        int i = 0;
        for(i = 0; i < newArray.GetLength(0); i++)
        {
            sumColum = sumColum + newArray[i, j];
            average = sumColum/(newArray.GetLength(0));
        }        
        Console.Write($"Среднее арифмитеческое {j + 1}-го столбца равно ");
        Console.Write("{0,6:F}", average);
        Console.WriteLine();
        j++;
    }
}
int[,] array = new int[5,10];
FillArray(array);
PrintArray(array);
AverageColumns(array);
//PrintArray(array);