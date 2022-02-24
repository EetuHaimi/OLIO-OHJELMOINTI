using System;
using System.Collections.Generic;
using System.Text;

namespace Car
{
    class Car
    {
        public string brand;
        public double speed;
        public Car()
        {
        }
        public Car(string brand, double speed)
        {
            this.brand = string.Empty;
            this.speed = 0;
        }
        internal void Accelerate()
        {
            throw new NotImplementedException();
        }
        public void AskData()
        {
            Console.WriteLine("Which brand is your car?");
            this.brand = Console.ReadLine();

            Console.WriteLine("What is your car's max speed?");
            if (double.TryParse(Console.ReadLine(), out this.speed))
            {
                Console.WriteLine(this.speed);              //syötön epäonnistuessa ohjelma ei kaadu
            }
            else
            {
                this.speed = 0;
            }
        }
        public void ShowCarInfo()
        {
            Console.WriteLine($"Auton merkki on {this.brand} ja nopeus on {this.speed}");
        }
        public void Accelerate(double value)
        {
            this.speed += value;
        }
        public void Brake()
        {
            this.speed *= 0.9;
        }
    }
}
