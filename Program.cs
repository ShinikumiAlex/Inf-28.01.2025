using System;

class Program
{
    static void Main()
    {
        double initialDistance = 10; // Пробег в первый день (км)
        double targetDistance = 20; // Цель а
        double totalDistanceTarget = 100; // б
        double dailyDistance = initialDistance; // Пробег за текущий день
        double totalDistance = 0; // Суммарный пробег
        int dayForTargetDistance = 0; // День, когда пробег превысит 20 км
        int dayForTotalDistance = 0; // День, когда суммарный пробег превысит 100 км

        int day = 1; 

        while (dayForTargetDistance == 0 || dayForTotalDistance == 0)
        {
            totalDistance += dailyDistance;

            if (dayForTargetDistance == 0 && dailyDistance > targetDistance)
            {
                dayForTargetDistance = day; // Зафиксировать день для а
            }

            if (dayForTotalDistance == 0 && totalDistance > totalDistanceTarget)
            {
                dayForTotalDistance = day; // Зафиксировать день дляб
            }

            dailyDistance *= 1.1; // Увеличиваем пробег на 10%
            day++;
        }

        Console.WriteLine($"а) Лыжник пробежит больше 20 км на {dayForTargetDistance} день.");
        Console.WriteLine($"б) Суммарный пробег превысит 100 км на {dayForTotalDistance} день.");
    }
}
