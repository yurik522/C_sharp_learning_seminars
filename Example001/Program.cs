// Задача 1: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
Console.WriteLine("Введите первое число:");
int FirstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int SecondNumber = Convert.ToInt32(Console.ReadLine());

if (FirstNumber * FirstNumber == SecondNumber){
  Console.WriteLine("Второе число является квадратом первого");

}
else{
  Console.WriteLine("Второе число не является квадратом первого");
}
