--UC1
Create Database Payroll_Service;
use Payroll_Service;

--UC2
Create table Employee_Payroll(
Id int primary key identity(1,1),
Name Varchar(30),
Salary Bigint,
StartDate DateTime
)

--UC3
Insert into Employee_Payroll(Name,Salary,StartDate) values('Somu','10000','2021-07-15');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Shekar','12000','2021-08-10');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Anil','11000','2021-07-05');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Kumar','10000','2021-07-16');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Manju','12000','2021-09-18');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Ramu','11000','2021-08-15');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Seetha','11000','2021-08-15');
Insert into Employee_Payroll(Name,Salary,StartDate) values('Rani','11000','2021-08-15');

--UC4
Select*from Employee_Payroll;

--UC5
Select*From Employee_Payroll where StartDate between cast('2021-07-16' as Date) and CURRENT_TIMESTAMP;

--UC6
Alter table Employee_Payroll Add Gender Varchar(1);
Update Employee_Payroll Set Gender='M' Where Name='Somu';
Update Employee_Payroll Set Gender='M' Where Name='Shekar';
Update Employee_Payroll Set Gender='M' Where Name='Anil';
Update Employee_Payroll Set Gender='M' Where Name='Kumar';
Update Employee_Payroll Set Gender='M' Where Name='Manju';
Update Employee_Payroll Set Gender='M' Where Name='Ramu';
Update Employee_Payroll Set Gender='F' Where Name='Seetha';
Update Employee_Payroll Set Gender='F' Where Name='Rani';

--UC7
Select SUM(Salary)from Employee_Payroll Where Gender='M' group by Gender;
Select SUM(Salary)from Employee_Payroll Where Gender='F' group by Gender;
Select AVG(Salary)from Employee_Payroll Where Gender='M' group by Gender;
Select AVG(Salary)from Employee_Payroll Where Gender='M' group by Gender;
Select MIN(Salary)from Employee_Payroll Where Gender='M';
Select MIN(Salary)from Employee_Payroll Where Gender='F';
Select MAx(Salary)from Employee_Payroll Where Gender='M';
Select MAX(Salary)from Employee_Payroll Where Gender='F';
Select COUNT(Salary) from Employee_Payroll group by Gender;

--UC8
Alter Table Employee_Payroll Add Phone Varchar(10), Address Varchar(100), Department Varchar(20);
Alter Table Employee_Payroll Alter column Department Varchar(20) Not Null;

--UC9
Alter Table Employee_Payroll Add BasicPay BigInt, Deductions BigInt, TaxablePay BigInt, IncomeTax BigInt, NetPay BigInt;

--UC10
Alter Table Employee_Payroll(Name,Salary,StartDate)
values('Terissa',1000,'2021-07-15');