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
        public static string connectionstring = "Data Source=(localdb)\\MSSQLLocalDB;Initial CataLog=Payroll_Service";
        SqlConnection connection = new SqlConnection(connectionstring);
        public void GetAllEmployeePayrollRecords()
        {
            try
            {
                Employe employee = new Employe();
                using (this.connection)
                {
                    string query = @"Select * from Employee_Payroll";
                    SqlCommand command = new SqlCommand(query, this.connection);
                    command.CommandType = CommandType.Text;
                    this.connection.Open();
                    SqlDataReader read = command.ExecuteReader();
                    if (read.HasRows)
                    {
                        while (read.Read())
                        {
                            employee.Id = read.GetInt32(0);
                            employee.Name = read.GetString(1);
                            employee.Salary = read.GetInt64(2);
                            employee.StartDate = read.GetDateTime(3);
                            employee.Gender = read.GetChar(4);
                            employee.Phone = read.GetString(5);
                            employee.Address = read.GetString(6);
                            employee.Department = read.GetString(7);
                            employee.BasicPay = read.GetInt64(8);
                            employee.Deductions = read.GetInt64(9);
                            employee.TaxablePay = read.GetInt64(10);
                            employee.IncomeTax = read.GetInt64(11);
                            employee.NetPay = read.GetInt64(12);
                        }
                        Console.WriteLine(employee.Id + "\n" + employee.Name + "\n" + employee.Salary + "\n" + employee.StartDate + "\n" + employee.Gender + "\n" + employee.Phone + "\n" + employee.Address + "\n" + employee.Department + "\n" + employee.BasicPay + "\n" + employee.Deductions + "\n" + employee.TaxablePay + "\n" + employee.IncomeTax + "\n" + employee.NetPay);
                    }
                    else
                    {
                        Console.WriteLine("NO Records Found");
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void AddEmployee(Employe employee)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand cmd = new SqlCommand("AddEmployee", this.connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Name", employee.Name);
                    cmd.Parameters.AddWithValue("@Salary", employee.Salary);
                    cmd.Parameters.AddWithValue("@StarDate", employee.StartDate);
                    cmd.Parameters.AddWithValue("@Gender", employee.Gender);
                    cmd.Parameters.AddWithValue("@Phone", employee.Phone);
                    cmd.Parameters.AddWithValue("@Address", employee.Address);
                    cmd.Parameters.AddWithValue("@Department", employee.Department);
                    cmd.Parameters.AddWithValue("@BasicPay", employee.BasicPay);
                    cmd.Parameters.AddWithValue("@Deductions", employee.Deductions);
                    cmd.Parameters.AddWithValue("@TaxablePay", employee.TaxablePay);
                    cmd.Parameters.AddWithValue("@IncomeTax", employee.IncomeTax);
                    cmd.Parameters.AddWithValue("@NetPay", employee.NetPay);
                    this.connection.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        Console.WriteLine("Employee Added Successfully");
                    }
                    else
                    {
                        Console.WriteLine("Employee Added UnSuccessfully");
                    }
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void DeleteEmployee(int Id)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("DeleteEmployee", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", Id);
                    this.connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (rowsAffected > 0)
                        Console.WriteLine("Employee Delete Succssefully");
                    else
                    {
                        Console.WriteLine("Employee Delete UnSuccssefully");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public void UpdateEmployee(int Id, string name)
        {
            try
            {
                using (this.connection)
                {
                    SqlCommand command = new SqlCommand("UpdateEmployee", this.connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Id", Id);
                    command.Parameters.AddWithValue("Name", name);
                    this.connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    this.connection.Close();
                    if (rowsAffected > 0)
                        Console.WriteLine("Employee Updated Succssefully");
                    else
                    {
                        Console.WriteLine("Employee Updated UnSuccssefully");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
