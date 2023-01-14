/*1. Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.
a = 5; b = 25 -> да 
a = 2 b = 10 -> нет 
a = 9; b = -3 -> нет 
a = -3 b = 9 -> да
*/

Console.Clear();
Console.WriteLine("Введи число А:");
String stringValue=Console.ReadLine();
int a=Convert.ToInt32(stringValue);
Console.WriteLine("Введи число B:");
stringValue=Console.ReadLine();
int b=Convert.ToInt32(stringValue);
if (b==a*a) {
    System.Console.WriteLine($"УРА, Число {b} является квадратом числа {a}");
    }
else{
    System.Console.WriteLine($"Число {b} НЕ является квадратом числа {a}");
    }