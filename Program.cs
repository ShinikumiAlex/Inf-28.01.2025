using System;

class Program
{
    static void Main()
    {
        int firstMonth = 100; 
        int increment = 50;  
        int months = 10;     
        int totalSum = 0;    

        for (int i = 0; i < months; i++)
        {
            int currentMonth = firstMonth + i * increment; 
            totalSum += currentMonth; 
        }

        Console.WriteLine($"Общая сумма через {months} месяцев: {totalSum} руб.");
    }
}
