using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicle
{
    class Car : Vehicle
    {
        
        protected double engine;
        protected string type;
        protected int doors;

        public Car()
        {
            this.engine = 0;
            this.type = string.Empty;
            this.doors = 2;
        }

        public Car(double engine, string type, int doors)
        {
            this.engine = engine;
            this.type = type;
            this.doors = doors;
        }

        public string make { get; internal set; }
        public string Model { get; internal set; }
        public string Year { get; internal set; }
        public string Price { get; internal set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Car other))
                return false;

            if (engine != other.engine || doors != other.doors)
                return false;

            return true;
        }

        public override string ToString()
        {
            return $"Kulkuvälineen koneen koko on: {this.engine}, kulkuvälineen malli on: {this.type}, kulkuvälineen ovien lukumäärä on: {this.doors}";
        }
    }
}
