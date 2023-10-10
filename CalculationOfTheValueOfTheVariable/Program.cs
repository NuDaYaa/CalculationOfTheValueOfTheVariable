using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите целое число n (n≤100):"); int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите два произвольных числа x и y:");
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        int k = n % 10;
        double z = 0;

        switch (k)
        {
            case 0:
                z = 1;
                break;
            case 1:
            case 7:
                z = x + y;
                break;
            case 2:
            case 5:
                z = x - Math.Pow(x, 2) * Math.Exp(y);
                break;
            case 8:
            case 9:
                z = x * y;
                break;
            case 3:
            case 4:
                z = x - Math.Sin(y);
                break;
            case 6:
                z = x - Math.Log(y);
                break;
        }

        Console.WriteLine("Результат: z = " + z);
    }
}