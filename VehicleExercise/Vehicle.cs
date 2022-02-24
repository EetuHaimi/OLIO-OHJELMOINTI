using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Vehicle
    {

        
       
        //public abstract void PrintInformation();

        //{
            
        //    Console.WriteLine($"Ajoneuvon moottori: {this.engine}, Ajoneuvon malli: {this.Type}, ovien lukumäärä: {this.doors}");
        //}
        abstract class vehicle
        {
            private string make;
            protected string model;
            protected int year;
            protected double price;

            protected string Make { get => Make; set => make = value; }

            public void PrintInformation(object engine, object door, object type)
            {
                Console.WriteLine($"engine: + {engine} model: + {type} door number: + {door}");
            }

            public vehicle()
            {
                this.make = string.Empty;
                this.model = string.Empty;
                this.year = 0;
                this.price = 0;
            }

            public vehicle(string make, string model, int modelyear, double price)
            {
                this.Make = make;
                this.model = model;
                this.year = modelyear;
                this.price = price;
            }
            public abstract void PrintInformation();

            public override string ToString()
            {
                Console.WriteLine($"Merkki: +  {make} Tyyppi: + {model} Vuosimalli + {year} Hinta: + {price}");
                return ("");

            }

            
        }
    }
}