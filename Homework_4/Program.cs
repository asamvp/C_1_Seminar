// Задача 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введи цифру:");
String stringValue=Console.ReadLine() ?? "";
int value=Convert.ToInt32(stringValue);
int i=1;
System.Console.WriteLine($"Все четные числа от 1 до {value}");
while (i<=value) 
{
    if (i%2==0) {
        System.Console.Write(i+" ");
    }
    i++;
}