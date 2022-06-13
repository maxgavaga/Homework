// Написать программу, которая на вход принимает число (N),
// а на выходе показывает все четные числа от одного до N.

Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine());
for (int i = a; i <= b; i++)
{
    if (i % 2 == 0) 
    {
        Console.Write( i + " ");
    }
}
