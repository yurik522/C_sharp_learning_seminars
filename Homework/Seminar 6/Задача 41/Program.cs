// Задача 41: Пользователь вводит с клавиатуры или задает самостоятельно M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
Console.WriteLine("Привет. Как будем задавать массив? Если хочешь вручную - жми 1, а если хочешь,"); 
Console.WriteLine ("чтобы я сам заполнил массив - нажми 2, после чего задай диапазон");
int  sumPosNumbers(int[] collection)
{   
    int result = 0;
    for (int i = 0; i < collection.Length; i++)
    {
       if (collection[i] > 0) result++;
    }
    return result;
}
void PrintArray(int[] col) 
{   int length = col.Length;
       for (int index =0; index < length; index++)
    {
       Console.Write($"{col[index]}, ");
    }
}
void FillArray(int[] newArray)
{
   Random rnd = new Random();
  for(int i = 0; i < newArray.Length; i++)
  {
    newArray[i] = rnd.Next(-20, 20);
  }
}
int userChoice = Convert.ToInt32(Console.ReadLine());
if (userChoice == 1)
   {
       Console.WriteLine("Пожалуйста, введите длину массива");
       int userLength = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("Вводите числа, входящие в состав массива");
       int [] array = new int[userLength];
       int i = 0;
       while(i < userLength)
       {
           array[i] = Convert.ToInt32(Console.ReadLine());
           i++;
       }
     Console.WriteLine("Задан следующий массив:");
     PrintArray(array);
     Console.WriteLine();
     Console.WriteLine($"Количество положительных чисел в массиве = {sumPosNumbers(array)}");
   }
   else if(userChoice == 2) 
          {
            Console.WriteLine("Я чувствовал, что придется все делать мне)))");
            int[] myArray = new int[15];
            FillArray(myArray);
            PrintArray(myArray);
            Console.WriteLine($"Количество положительных чисел в массиве = {sumPosNumbers(myArray)}");
          }
          else Console.WriteLine("Друг мой, не могу понять, что тебе нужно, попробуй еще раз");
          