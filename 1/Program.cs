/*Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).
Например:
4 -> 16 
-3 -> 9 
-7 -> 49
*/

Console.Clear();
Console.WriteLine("Введи цифру:");
String stringValue=Console.ReadLine();
int value=Convert.ToInt32(stringValue);
int result=value*value;
System.Console.WriteLine($"Квадрат числа {value} равен {result}");