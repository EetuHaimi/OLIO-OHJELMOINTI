using System;

namespace CompanyExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Company exercise");
            
            Company saha = new Company();
            saha.CompName = "Lappeenrannan Saha";
            saha.address = "Sahakatu 69";
            saha.phone = "0444344344";
            saha.outcome = 8000f;
            saha.expenses = 2500f;
            saha.Voitto();
            
            Company kauppa = new Company("Kaken Kauppa", "Kauppakatu 99", "045 434 4346", 27750, 25000);
            kauppa.Voitto();

            Company autoKauppa = new Company(kauppa);
            autoKauppa.Voitto();

        }

        
    }
}
