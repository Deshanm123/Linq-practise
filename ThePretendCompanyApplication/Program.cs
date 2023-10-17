using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TCPData;
using TCPExtensions;

//Average
var employeeList = Data.GetEmployees();

int totalEmployee =  employeeList.Count();
Console.WriteLine("Total employee Count "+ totalEmployee);


int totalEmployeeInDepartment3 =  employeeList.Count(emp => emp.DepartmentId == 3);
Console.WriteLine("total number of employees in  department  3 " + totalEmployeeInDepartment3);