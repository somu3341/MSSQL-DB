using System;
namespace EmployeeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Option option = new Option();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Choose option to perform\n1.Get Employee Payroll Records\n2.Add Employee deatails\n3.Delete Employee Deatils\n4.Update Employee Deatils\n5.Exit");
                int opt=Convert.ToInt32(Console.ReadLine());                
                switch (opt)
                {
                    case 1:
                        option.GetAllEmployeePayrollRecords();
                        
                        break;
                        case 2:
                        Employe employe1 = new Employe()
                        {
                            Name = "Somu",
                            Salary = 1000,
                            StartDate = DateTime.Now,
                            Gender = "M",
                            Phone = "9093938839",
                            Address = "Banglore",
                            Department = "Sales",
                            BasicPay = 100,
                            Deductions = 200,
                            TaxablePay = 100,
                            IncomeTax = 100,
                            NetPay = 100
                        };
                        option.AddEmployee(employe1);                      
                        break;
                        case 3:
                        Employe employe2 = new Employe()
                        {
                            Id = 1,
                        };
                        option.DeleteEmployee(employe2.Id);
                        break;
                        case 4:
                        Employe employe3 = new Employe()
                        {
                            Id = 2,
                            Name = "AjthKumar"
                        };
                        option.UpdateEmployee(employe3.Id, employe3.Name);
                        break;
                        case 5:
                        flag = false;
                        break;
                }
            }
           
            
            //
        }
    }
}