void SpiralFilling(int[,] matrix)
{
    int value = 1;
    int maxValue = matrix.GetLength(0) * matrix.GetLength(1) + 1; //увеличим на единицу, чтобы каждый раз не прописывать это в циклах
    int m = matrix.GetLength(0); //отвязываемся от фиксированных размеров массива для движения по спирали (слева-направо и сверху-вниз)
    int n = matrix.GetLength(1);
    int a = 0; //для контроля заполнения после прохода периметра (справа-налево и снизу вверх)
    int b = 0; // т. е. для смещения от края
    int i = 0;
    int j = 0;
    for (; value < maxValue; i++, j++, a++, b++, m--, n--)
    {
        for (; j < n; j++)
        {
            if (value == maxValue)
                break;
            matrix[i, j] = value;
            value++;
        }
        j--;
        i++;
        for (; i < m; i++)
        {
            if (value == maxValue)
                break;
            matrix[i, j] = value;
            value++;
        }
        i--;
        j--;
        for (; j >= a; j--)
        {
            if (value == maxValue)
                break;
            matrix[i, j] = value;
            value++;
        }
        j++;
        i--;
        for (; i > b; i--)
        {
            if (value == maxValue)
                break;
            matrix[i, j] = value;
            value++;
        }
        Console.WriteLine($"j={j}, i={i}");
        Console.WriteLine();
    }
}
void PrintArray(int[,] newArray)
{
    for (int i = 0; i < newArray.GetLength(0); i++)
    {
        for (int j = 0; j < newArray.GetLength(1); j++)
        {
            Console.Write("{0,4}", newArray[i, j]);
        }
        Console.WriteLine();
    }
}

int[,] array = new int[9, 13];
SpiralFilling(array);
PrintArray(array);
