//Задача 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Clear();
Console.WriteLine("Введи цифру:");
String stringValue=Console.ReadLine() ?? "";
int value=Convert.ToInt32(stringValue);
int result=value%2;
if (result==0) {System.Console.WriteLine("Число четное");}
else {System.Console.WriteLine($"Число нечетное, делится с остатком {result}");}