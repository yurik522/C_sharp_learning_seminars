// Написать программу, которая на входе принимает 3-х значное число, а на выходе показывает 
//2-ю цифру этого числа.
Console.WriteLine("Введите трехзрачное число");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = numberA % 100;
if (numberB < 10)
{
    Console.WriteLine($"Вторая цифра числа {numberA} равна 0");
}
else
{
    int numberC = numberB / 10;
    Console.WriteLine($"Вторая цифра числа {numberA} равна {numberC}");  
}