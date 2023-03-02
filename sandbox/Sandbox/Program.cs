using System;

class Program
{
    static void Main(string[] args)
    { 
       List<Employee> employees = new List<Employee>();
       employees.Add(new SalaryEmployee());
       employees.Add(new HourlyEmployee());

       foreach (Employee employee in employees)
       {
         float pay = employee.CalculatePay();
         Console.WriteLine(pay);
       }
    }
}