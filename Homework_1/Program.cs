/*Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.*/

Console.Clear();
Console.WriteLine("Введи число А:");
String stringValue=Console.ReadLine();
int a=Convert.ToInt32(stringValue);
Console.WriteLine("Введи число B:");
stringValue=Console.ReadLine();
int b=Convert.ToInt32(stringValue);
if (a>b) {
    System.Console.WriteLine($"Число {a} больше чем число {b}");
    }
if (a<b) {
    System.Console.WriteLine($"Число {b} больше чем число {a}");
    }
if (a==b) {
    System.Console.WriteLine($"Число {a} равно числу {b}");
    }