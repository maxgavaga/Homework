// Напишите программу, которая на вход принимает три числа
// и выдает максимальное из этих чисел.

    int a, b, c;
    Console.WriteLine("Введите три числа:   ");
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    c = Convert.ToInt32(Console.ReadLine());
    if ((a > b) && (a > c))
    System.Console.WriteLine("{0} - это максимальное число", a);
        else if (b > c)
        System.Console.WriteLine("{0} - это максимальное число", b);
    else
     System.Console.WriteLine("{0} - это максимальное число", c);   