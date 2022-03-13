// Напишите программу, которая принимает три числа и выдаёт максимальное из этих чисел


Console.WriteLine( "Введите первое число" );
int NumberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "ВВедите второе число" );
int NumberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "ВВедите третье число" );
int NumberC = Convert.ToInt32(Console.ReadLine());
int max = NumberA;
if (NumberB > max) max = NumberB;
if (NumberC > max) max = NumberC;

Console.Write("max = ");
Console.WriteLine(max);