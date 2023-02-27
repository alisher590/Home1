//Homework1

Console.Write("Введите первое число:");
int First_Num = int.Parse(Console.ReadLine()??"");

Console.Write("Введите второе число:");
int Second_Num = int.Parse(Console.ReadLine()??"");

if( First_Num < Second_Num){
     Console.WriteLine($"{"первое число"} -> {Second_Num} -> {"Больше чем второе число"}{First_Num}");
}
else {
   Console.WriteLine($"{"второе число"}{First_Num} -> {"Больше чем первое число"} -> {Second_Num}");
    
}


    



