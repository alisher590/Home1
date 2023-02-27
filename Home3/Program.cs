//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число:");
int Number = int.Parse(Console.ReadLine()??"");
if(Number %2 == 0){
    Console.WriteLine("Это чётное число");
}
else{
    Console.WriteLine("Это НЕчётное число");
}


