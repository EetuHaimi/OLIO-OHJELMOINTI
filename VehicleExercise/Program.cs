using System;

namespace Vehicle
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.make = "Range Rover";
            myCar.Model = "Vogue";
            myCar.Year = "2016";
            myCar.Price ="86900";

            Console.WriteLine("Auton merkki on: " + myCar.make + " ja malli on: " + myCar.Model + " Valmistusvuosi: " + myCar.Year + " ja hinta: " + myCar.Price);
            //myCar.PrintInformation();
        }
    }
}
