using InsuranceDemo;
using System;

namespace Insurance
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            InsuranceManager im = new InsuranceManager();
            im.AddInsurance("koira", "Musti", false);
            im.AddInsurance("koira", "Mirtsa", true);
            im.AddInsurance("kissa", "Jezze", true);
            im.AddInsurance("koira", "NikoC", false);
            im.AddInsurance("lintu", "Putin", false);
            im.PrintInsurances();
            Console.WriteLine("---");
            im.FindInsurances("koira", false);
        }
    }
}