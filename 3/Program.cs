/*
. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
	3 -> Среда 
    5 -> Пятница
*/
Console.Clear();
System.Console.Write("Введите номер дня недели: ");
String stringValue = Console.ReadLine();
int value = Convert.ToInt32(stringValue);

if(value==1){
    System.Console.WriteLine($"День недели для номера {value} - понедельник");    
}else if(value==2){
    System.Console.WriteLine($"День недели для номера {value} - вторник");    
}else if(value==3){
    System.Console.WriteLine($"День недели для номера {value} - среда");    
}else if(value==4){
    System.Console.WriteLine($"День недели для номера {value} - четверг");    
}else if(value==5){
    System.Console.WriteLine($"УРА, День недели для номера {value} - пятница");    
}else if(value==6){
    System.Console.WriteLine($"День недели для номера {value} - суббота");    
}else if(value==7){
    System.Console.WriteLine($"День недели для номера {value} - воскресенье");    
}else{
    System.Console.WriteLine($"Календарь сбился ))) нет такого дня: {value}");   
}
