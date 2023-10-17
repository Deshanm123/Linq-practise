using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TCPData;
using TCPExtensions;

//Average
var employeeList = Data.GetEmployees();

decimal averageSal = employeeList.Average(e => e.AnnualSalary);
Console.WriteLine("average salary of an employee " + averageSal);


//finding average salary in a particular technology  department

var technologyDep = Data.GetDepartments().FirstOrDefault(dep => dep.LongName == "Technology");
decimal averageSalaryOfTechnologyEmployee = employeeList
                                    .Where(emp => emp.DepartmentId == technologyDep.Id)
                                    .Average(techEmp => techEmp.AnnualSalary);

Console.WriteLine("Average Salary Of Technology Employee" + averageSalaryOfTechnologyEmployee);