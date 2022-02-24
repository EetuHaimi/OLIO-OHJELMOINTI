using System;

namespace EmployeeExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Luodaan Employee-olioita ja tallennetaan ne taulukkoon.");
            Employee[] employees = new Employee[4];
            employees[0] = new Employee("Miro", "Miettinen", "66969", "Toimari", 125000f);
            employees[1] = new Employee("Niko", "Keskinen", "66967", "Siivooja", 11000f);
            employees[2] = new Employee("Jami", "Suomalainen", "66888", "Kuski", 45000f);
            employees[3] = new Employee("Jesse", "Pihlajärvi", "66444", "Oven avaaja", 11000f);
            Console.WriteLine($"Employee taulukossa on {employees.Length} Employee-oliota");
            for (int i = 0; i < employees.Length; i++)
            {               
                if (i + 1 > employees.Length - 1)
                {                   
                    employees[i].CompareSalary(employees[0]);
                }
                else
                {
                    employees[i].CompareSalary(employees[i + 1]);
                }
            }
            Console.WriteLine("\n\n"); 
            for (int u = 0; u < employees.Length; u++)
            {
                employees[u].PrintEmployeeInfo();
            }
        }
    }
}
