// Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();
Console.WriteLine("Введи число А:");
String stringValue=Console.ReadLine() ?? "";
int a=Convert.ToInt32(stringValue);
Console.WriteLine("Введи число B:");
stringValue=Console.ReadLine() ?? "";
int b=Convert.ToInt32(stringValue);
Console.WriteLine("Введи число C:");
stringValue=Console.ReadLine() ?? "";
int c=Convert.ToInt32(stringValue);
int max=a;

if (b>max) {max=b;}
if (c>max) {max=c;}

System.Console.WriteLine($"Максимальное число = {max}");