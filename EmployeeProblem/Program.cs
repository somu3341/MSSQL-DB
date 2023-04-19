using System;
namespace EmployeeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Option option = new Option();
            //option.GetAllEmployeePayrollRecords();
            Employe employe = new Employe()
            //{
            //    Name = "Somu",
            //    Salary = 1000,
            //    StartDate = new DateTime(09-08-2020),
            //    Gender = 'M',
            //    Phone = "9093938839",
            //    Address = "Banglore",
            //    Department = "Sales",
            //    BasicPay = 100,
            //    Deductions = 200,
            //    TaxablePay = 100,
            //    IncomeTax = 100,
            //    NetPay = 100
            //};
            //option.AddEmployee(employe);
            //{
            //    Id = 5,
            //};
            //option.DeleteEmployee(employe.Id);
            {
                Id = 2,
                Name = "Somu",
            };
            option.UpdateEmployee(employe.Id,employe.Name);
        }
    }
}