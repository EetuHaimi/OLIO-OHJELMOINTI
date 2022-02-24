using System;

namespace Car
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Car exercise: ");

            Car car = new Car();
            Car car1 = car;
            car1.AskData();
            car1.Accelerate(20);
            Console.WriteLine($"Nopeutta muutettu {car1.speed}");
            car1.Brake();
            Console.WriteLine($"Jarrutettu, nopeus on nyt {car1.speed}");
            car1.ShowCarInfo();

            Car auto = new Car();
            Car car2 = car;
            car2.AskData();
            Console.WriteLine($"Kiihdytetty, nopeus on nyt {car2.speed}");
            car2.Brake();
            Console.WriteLine($"Jarrutettu, nopeus on nyt {car2.speed}");
            car2.ShowCarInfo();
        }
    }
}