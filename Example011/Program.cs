// Задача 11. Дано число из 
// отрезка [10, 99]. Показать наибольшую цифру числа
int numberA = new Random().Next(10, 99);

Console.WriteLine($"Последнняя цифра числа {numberA}");
{
    int a = numberA % 10;
    Console.Write($"равна {a}");
}