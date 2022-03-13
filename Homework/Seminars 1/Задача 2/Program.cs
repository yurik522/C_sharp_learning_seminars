// Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("ВВедите два числа");
int numberA = Console.ReadLine();
int numberB = Console.ReadLine();
if (numberA > numberB)
{
    Console.Write("max=");
    Console.WriteLine(numberA);
}
else
{
    Console.Write("max=");
    Console.WriteLine(numberB);
}