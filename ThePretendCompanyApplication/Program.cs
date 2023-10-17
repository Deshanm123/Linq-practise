using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TCPData;
using TCPExtensions;

//Aggregate functions


var employeeList = Data.GetEmployees();
decimal totalAnnualSalary = employeeList.Aggregate<Employee, decimal>(0, (totalAnnualSalary, emp) =>
{
    var bonus = emp.IsManager ? 0.04m : 0.02m;
    totalAnnualSalary = (emp.AnnualSalary + (emp.AnnualSalary * bonus) ) + totalAnnualSalary;
    return totalAnnualSalary;

});

Console.WriteLine($"Total Annual salary oof all emloyees with bonus : {totalAnnualSalary} ");


string employeeData = employeeList.Aggregate<Employee, string>("Employeee Annual Salaries including bonus \n", (s, emp) =>
{
    var bonus = emp.IsManager ? 0.04m : 0.02m;
    s += $"{emp.FirstName} {emp.LastName} - {emp.AnnualSalary + emp.AnnualSalary * bonus} \n";
    return s;
});


    Console.WriteLine(employeeData);
