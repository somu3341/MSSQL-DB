using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Option
    {
        public static string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial catalog=Payroll_Service";
        SqlConnection connection=new SqlConnection(connectionString);
        public void GetAllEmployeePayrollRecords()
        {
            Employe employe = new Employe();
            try
            {           
                using(this.connection)
                {
                    string query = @"select * from Employee_Payroll";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if(read.HasRows)
                    {
                        while (read.Read())
                        {
                            employe.Id = read.GetInt32(0);
                            employe.Name = read.GetString(1);
                            employe.Salary = read.GetInt64(2);
                            employe.StartDate = read.GetDateTime(3);
                            employe.Gender = read.GetChar(4);
                            employe.Phone = read.GetString(5);
                            employe.Address = read.GetString(6);
                            employe.Department=read.GetString(7);
                            employe.BasicPay = read.GetInt64(8);
                            employe.Deductions = read.GetInt64(9);
                            employe.TaxablePay = read.GetInt64(10);
                            employe.IncomeTax = read.GetInt64(11);
                            employe.NetPay = read.GetInt64(12);
                            Console.WriteLine(employe.Id + "\n" + employe.Name + "\n" + employe.Salary + "\n" + employe.StartDate + "\n" + employe.Gender + "\n" + employe.Phone + "\n" + employe.Address + "\n" + employe.Department + "\n" + employe.BasicPay + "\n" + employe.Deductions + "\n" + employe.TaxablePay + "\n" + employe.IncomeTax + "\n" + employe.NetPay);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No Records Available");
                    }
                }
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
