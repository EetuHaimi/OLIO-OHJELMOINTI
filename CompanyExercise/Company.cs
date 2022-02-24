using System;
using System.Collections.Generic;
using System.Text;

namespace CompanyExercise
{
    class Company
    {
        public string address;
        public string CompName;
        public string phone;
        public float outcome;
        public float expenses;


        //empty constructor 

        public Company()
        {
            this.address = string.Empty;
            this.CompName = string.Empty;
            this.phone = string.Empty;
            this.outcome = 0;
            this.expenses = 0;
        }

        

        public Company(string CompName, string address, string phone, float outcome, float expenses)
        {
            this.CompName = CompName;
            this.address = address;
            this.phone = phone;
            this.outcome = outcome;
            this.expenses = expenses;

        }

        //Copy Constructor

        public Company(Company company)
        {
            this.CompName = company.CompName;
            this.address = company.address;
            this.phone = company.phone;
            this.outcome = company.outcome;
            this.expenses = company.expenses;

        }
 

        public void Voitto()
        {
            string low = "Firmalla menee kehnosti: ";
            string passable = "Firmalla menee välttävästi: ";
            string average = "Firmalla menee tyydyttävästi: ";
            string good = "Firmalla menee hyvin: ";

            float voittoPros = ((outcome - expenses) / expenses * 100);

            if (voittoPros > 300)
            {
                Console.WriteLine(good + voittoPros + "%");
            }
            else if (voittoPros > 200 && voittoPros < 300)
            {
                Console.WriteLine(average + voittoPros + "%");
            }
            else if (voittoPros > 100 && voittoPros < 200)
            {
                Console.WriteLine(passable + voittoPros + "%");
            }
            else if (voittoPros < 100)
            {
                Console.WriteLine(low + voittoPros + "%");
            }
            



        }
    }
}

