// Написать программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее
Console.WriteLine("ВВедите два числа, между числами используйте 'Enter'");
int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
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