// Задача 9. Показать последнюю цифру трехзначного числа

//int fnumber = new Random().Next(100, 1000);
//Console.Writline($"Последняя цифра {fnumber}");
//if (fnumber > 99 & fnumber < 1000) {
//    int a = fnumber % 10;
//    Console.Write("Последняя цифра "

using System;
string numer = Convert.ToString(new Random().Next(100,1000));
Console.WriteLine(numer);
Console.WriteLine(numer.Substring(2));
