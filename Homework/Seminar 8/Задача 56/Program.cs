// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
void FillArray(int[,] newArray) //заполяем массив
{
    Random rnd = new Random();
    for(int i = 0; i < newArray.GetLength(0); i++)
    {
        for(int j = 0; j < newArray.GetLength(1); j++)
        {
            newArray[i, j] = rnd.Next(-15, 15);
        }

    }
}
void PrintArray(int[,] newArray)//печатаем массив
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
void SumString(int[,] newArray) //печатаем суммы элементов в каждой строке   
{
    int sumString = 0;
    for(int i = 0; i < newArray.GetLength(0); i ++)
    {
        for(int j = 0; j < newArray.GetLength(1); j ++)
        {
            sumString = sumString + newArray[i, j];
        }
        //double average = sumColum/(newArray.GetLength(0));
        Console.Write($"Сумма элементов {i + 1}-й строки равна ");
        Console.Write(sumString);
        sumString = 0;
        Console.WriteLine();
    }
}
int[] ArraySumString(int[,] newArray) //собираем минимальные значения сумм чисел в строках в массив   
{
    int sumString = 0;
    int[] ArraySum = new int[newArray.GetLength(0)];
    for(int i = 0; i < newArray.GetLength(0); i ++)
    {
        for(int j = 0; j < newArray.GetLength(1); j ++)
        {
            sumString = sumString + newArray[i, j];
        }
        ArraySum[i] = sumString;
        sumString = 0;
    }
    return ArraySum;
}
void minSumString(int[] arraySort) //находим минимальное значение и выдаём результат
{
    int i = 0;
    int min = arraySort[i];
    int minIndex = i;
    for (i = 0; i < arraySort.Length; i++)
    {
        if(arraySort[i] < min)
        { 
          min = arraySort[i];
          minIndex = i + 1; //фиксируем строку, в которой находится минимальная сумма элеметов. Добавляем к значению
                            //единицу, чтобы вывод был логически понятным рядовому пользователю.
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Минимальная сумма элементов находится в {minIndex}-й строке  и равна {min}"); 
}
Console.WriteLine("Введите количество строк в массиве:");
int s = Convert.ToInt16(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве:");
int c = Convert.ToInt16(Console.ReadLine());
int[,] array = new int[s,c];
FillArray(array);
PrintArray(array);
Console.WriteLine();
SumString(array);
minSumString(ArraySumString(array));
