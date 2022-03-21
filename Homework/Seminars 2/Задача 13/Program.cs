// Выяснить, кратно ли число заданному, если нет, вывести остаток.
Console.WriteLine( "Введите первое число" );
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine( "ВВедите второе число" );
int secondNumber = Convert.ToInt32(Console.ReadLine());
int divNumber = firstNumber % secondNumber;
if(divNumber == 0)
    {
        Console.Write($" {secondNumber} кратно  {firstNumber}");
    }
else
{
    Console.WriteLine($"{secondNumber} не кратно {firstNumber}");
    Console.WriteLine($"Остаток {divNumber}");
}
