using System;
using System.Collections.Generic;
using System.Text;

namespace InsuranceDemo
{
    public class Insurance
    {
        public string species;
        public string name;
        public bool neutered;
        public double fee;
        public Insurance(string animal, string name, bool isNeutered, double payment)
        {
            this.species = animal;
            this.name = name;
            this.neutered = isNeutered;
            this.fee = payment;
        }
        public string GetNeuteredInfo()
        {
            if (neutered)
            {
                return "leikattu";
            }
            else
            {
                return "leikkaamaton";
            }
        }
        public override string ToString()
        {
            return species + ": " + name + ", " + GetNeuteredInfo();
        }
    }
}