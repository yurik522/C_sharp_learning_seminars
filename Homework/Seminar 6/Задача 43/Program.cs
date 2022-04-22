//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем или задаются вручную.
Console.WriteLine("Введите значения коэффициентов для первой прямой (y1 = K1X + B1)");
Console.Write(" K1 = ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.Write(" B1 = ");
double B1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значения коэффициентов для второй прямой (y2 = K2X + B2");
Console.Write(" K2 = ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.Write(" B2 = ");
double B2 = Convert.ToDouble(Console.ReadLine());
if(K1 == K2) 
   {
       Console.WriteLine("Прямые не пересекаются");
   }
else 
    {
        Console.WriteLine("Ищем точки перечечения для следющих прямых:   "
                + $"y1 = {K1}X + {B1},   "
                + $"y2 = {K2}X + {B2}");
    double x = (B2 - B1)/(K1 - K2);
    double y = K1*x + B1;
    Console.WriteLine($"Прямые пересекаются в точке с координатами ({x}, {y})");
    }