using System;

class Program
{
    static void Main()
    {
        int a1 = 1; 
        int d = 4;  
        int n = 5;  
        int sum = 0; 

        Console.WriteLine("Первые пять членов арифметической прогрессии:");
        for (int i = 0; i < n; i++)
        {
            int currentTerm = a1 + i * d; 
            Console.Write(currentTerm + " "); 
            sum += currentTerm; 
        }

        Console.WriteLine($"\nСумма: {sum}");
    }
}
