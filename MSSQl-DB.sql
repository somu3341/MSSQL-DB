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
update Employee_Payroll set Phone='9809878645',Address='Kolar',Department='Production',BasicPay='',Deductions='',TaxablePay='',IncomeTax='',NetPay='';
update Employee_Payroll set Phone='9453358645',Address='KGF',Department='QA',BasicPay='',Deductions='',TaxablePay='',IncomeTax='',NetPay='';
update Employee_Payroll set Phone='8969878645',Address='Banglore',Department='Finance',BasicPay='',Deductions='',TaxablePay='',IncomeTax='',NetPay='';
update Employee_Payroll set Phone='9809812325',Address='Shivamoga',Department='HR',BasicPay='',Deductions='',TaxablePay='',IncomeTax='',NetPay='';
update Employee_Payroll set Phone='7845478645',Address='Manglore',Department='Delivary',BasicPay='',Deductions='',TaxablePay='',IncomeTax='',NetPay='';


--UC10
Insert into Employee_Payroll(Name,Salary,StartDate,Gender,Phone,Address,Department,BasicPay,Deductions,TaxablePay,IncomeTax,NetPay)
values('Terissa',1000,'2021-07-15','F','9800988978','Banglore','Sales',100,100,100,100,500);
Insert into Employee_Payroll(Name,Salary,StartDate,Gender,Phone,Address,Department,BasicPay,Deductions,TaxablePay,IncomeTax,NetPay)
values('Terissa',1000,'2021-07-15','F','9800988978','Banglore','Marketing',100,100,100,100,500);

--UC11
Create table Department
(
Id int primary key identity(1,1),
DeptName Varchar(20),
EmployeeID int Foreign key REFERENCES Employee_Payroll(Id)
)
Insert into Department(DeptName,EmployeeId) values('Sales',1);
Insert into Department(DeptName,EmployeeId) values('Marketing',1);
Select*from Department;

--UC12
Select*from Employee_Payroll;

Create Procedure AddEmployee
(
@Name Varchar(30),
@Salary Bigint,
@StartDate Date,
@Gender Varchar(30),
@Phone Varchar(10),
@Address Varchar(100),
@Department Varchar(100),
@BasicPay BigInt,
@Deductions BigInt,
@TaxablePay BigInt,
@IncomeTax BigInt,
@NetPay BigInt
)
As
Begin
Insert into Employee_Payroll values(@Name,@Salary,@StartDate,@Gender,@Phone,@Address,@Department,@BasicPay,@Deductions,@TaxablePay,@IncomeTax,@NetPay);
End

Create Procedure DeleteEmployee
(
@Id int
)
As
Begin
Delete from Employee_Payroll Where Id=@Id;
End

Create Procedure UpdateEmployee
(
@Id int
@Name varchar(30)
)
As
Begin
Update from Employee_Payroll set Id=@Id,Name=@Name;
End