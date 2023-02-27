//Homework 4
//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число : ");
int Num_A = int.Parse(Console.ReadLine() ?? "");
Console.Write("Все четные числа от 1 до.. : ");
int Num_B = int.Parse(Console.ReadLine() ?? "");
for (int i = Num_A; i <= Num_B; i++)
{
    if (i % 2 == 0)
    {
        Console.Write(i + " ");
    }
}
