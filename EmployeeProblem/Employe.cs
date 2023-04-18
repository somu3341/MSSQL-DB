using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeProblem
{
    public class Employe
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Double Salary { get; set; }
        public DateTime StartDate { get; set; }
        public char Gender { get; set; }
        public String Phone { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public Double BasicPay { get; set; }
        public Double Deductions { get; set; }
        public Double TaxablePay { get; set; }
        public Double IncomeTax { get; set; }
        public Double NetPay { get; set; }
    }
}
