using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TCPData;
using TCPExtensions;

var employeeList = Data.GetEmployees();

decimal totalSal =  employeeList.Sum(e => e.AnnualSalary);
Console.WriteLine("Sum of employee Salaries "+ totalSal);


decimal maximumSal =  employeeList.Max(emp => emp.AnnualSalary);
Console.WriteLine("MAximum Salary amoung employee is  " + maximumSal);