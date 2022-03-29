//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("введите число A");

int A = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число B");

int B = Convert.ToInt32(Console.ReadLine());
// double result = Math.Pow(A, B);
// Console.WriteLine(result);

int BExp = 1;

for (int i = 1; i <=B; i++)
{
    BExp = BExp * A;
}
Console.WriteLine($"Число {A}, возведенное в степень {B} равно {BExp}");