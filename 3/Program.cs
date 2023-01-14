/*
. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
    5 -> Пятница
*/
Console.Clear();
System.Console.Write("Введите номер дня недели: ");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);
if (value<8)
{
    string[] week = new string[] {"понедельник","вторник","среда","четверг","УРА, пятница","суббота","воскресенье"};
    System.Console.WriteLine($"День недели для номера {value} - {week[value-1]}");   
}
else{
    System.Console.WriteLine($"Календарь сбился ))) нет такого дня: {value}");   
}