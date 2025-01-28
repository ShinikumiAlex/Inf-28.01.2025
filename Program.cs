using System;

class Program
{
    static void Main()
    {
        double a1 = -200; 
        double d = 0.2;   
        int n = 150;      

        // Формулапрогрессии: S = n / 2 * (a1 + an)
        double an = a1 + (n - 1) * d; 
        double sum = n / 2.0 * (a1 + an); 

        Console.WriteLine($"Сумма {n} первых членов арифметической прогрессии: {sum}");
    }
}
