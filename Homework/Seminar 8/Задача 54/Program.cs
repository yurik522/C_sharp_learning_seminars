// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива(в пределах всего массива).
void FillArray(int[,] newArray)
{
    Random rnd = new Random();
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = rnd.Next(-20, 20);
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

void SelectionSort(int[,] SortArray) 
{
   for(int i = 0; i < SortArray.GetLength(0); i ++)
    {
        for(int j = 0; j < SortArray.GetLength(1) - 1; j ++)
        {          
            int maxPosition = j; 
            for(int k = j + 1; k < SortArray.GetLength(1); k ++)
            {
               if(SortArray[i, k] > SortArray[i, maxPosition]) maxPosition = k;
            }
            int temporary = SortArray[i, j];
            SortArray[i, j] = SortArray[i, maxPosition];
            SortArray[i, maxPosition] = temporary;                            
            
        }
    }
}

// {
//     for(int i = 0; i < array.Length - 1; i++)
//     {
//          int maxPosition = i; 
//         for(int j = i + 1; j < array.Length; j++ )
//         {
//             if(array[j] > array[maxPosition]) maxPosition = j;
//         }
//         int temporary = array[i];
//         array[i] = array[maxPosition];
//         array[maxPosition] = temporary;                            
//     }
// }
Console.WriteLine("Введите количество строк в массиве:");
int s = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int c = Convert.ToInt16(Console.ReadLine());
int[,] array = new int[s,c];
FillArray(array);
PrintArray(array);
//AverageColumns(array);
//PrintArray(array);
Console.WriteLine();
SelectionSort(array);
PrintArray(array);