// Homework 2
Console.Write("Введите первое число:");
int First_Num = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите второе число:");
int Second_Num = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите третье число:");
int Third_Num = int.Parse(Console.ReadLine() ?? "");

int maximum = First_Num;
if (maximum < Second_Num)
{
    maximum = Second_Num;
    if (maximum < Third_Num)
    {
        maximum = Third_Num;
    }
}
Console.WriteLine(maximum);


