// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса нечётные, 
// и замените эти элементы на их квадраты.
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
void ChangeArray(int[,] newArray)
{
    for(int i = 1; i < newArray.GetLength(0); i += 2)
    {
        for(int j = 1; j < newArray.GetLength(1); j += 2)
        {
            newArray[i, j] = Convert.ToInt32(Math.Pow(newArray[i, j], 2));
        }
    }
}
int[,] array = new int[6,6];
FillArray(array);
PrintArray(array);
Console.WriteLine("Преобразованный массив:");
ChangeArray(array);
PrintArray(array);