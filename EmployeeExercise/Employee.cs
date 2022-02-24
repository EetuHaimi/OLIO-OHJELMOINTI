using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeExercise
{
    class Employee
    {
        public string firstName;
        public string lastName;
        public string id;
        public string position;
        public float salary;
        public Employee(string firstName, string lastName, string id, string position, float salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            this.position = position;
            this.salary = salary;
        }
        public override string ToString()
        {
            return $"{this.lastName} {this.firstName}, {this.salary}, {this.id}, {this.position}";
        }       
        public void CompareSalary(Employee employee)
        {                              
            if (this.salary > employee.salary)
            {
                Console.WriteLine($"{this.firstName} {this.lastName} {this.salary} palkka on suurempi kuin {employee.firstName} {employee.lastName}, {employee.salary}");
            }
            else if (this.salary < employee.salary)
            {
                Console.WriteLine($"{this.firstName} {this.lastName} {this.salary} palkka on pienempi kuin {employee.firstName} {employee.lastName}, {employee.salary}");
            }
            else
            {
                Console.WriteLine($"{this.firstName} {this.lastName} {this.salary} palkka on sama kuin {employee.firstName} {employee.lastName}, {employee.salary}");
            }                                   
        }
        public void PrintEmployeeInfo()
        {
            Console.WriteLine(this.ToString());
        }
    }
}
