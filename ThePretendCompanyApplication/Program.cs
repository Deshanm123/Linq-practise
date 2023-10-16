﻿using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TCPData;
using TCPExtensions;



//ineer join  by method syntax
var employeeList = Data.GetEmployees();
var departmentList = Data .GetDepartments();


//var resultsOfMethodSyntax = departmentList.Join(
//    employeeList, //outer join set
//    department => department.Id, // key oiin inner data set
//    employee => employee.DepartmentId,// outer key in outer dataset
//    (department, employee) => new
//    {
//        EmployeeId = employee.Id,
//        DepartmentId = department.Id,
//        FullName = employee.FirstName + " " + employee.LastName,
//        Salary = employee.AnnualSalary,
//        DepartmentName = department.LongName
//    }
//    );

//var descendingOrderEmployee = resultsOfMethodSyntax.OrderByDescending(emp => emp.EmployeeId);

//Console.ReadKey();

//foreach (var res in descendingOrderEmployee)
//{
//    Console.WriteLine($"{res.FullName} (e-ID{res.EmployeeId}) works at  {res.DepartmentName} (departmentID- {res.DepartmentId}) and earns {res.Salary}" );
//}

////inner jin by query syntax

//var resultsOfQuerySyntax = from employee in employeeList
//          join department in departmentList
//          on employee.DepartmentId equals department.Id
//          orderby employee.AnnualSalary
//        select new
//          {
//              EmployeeId = employee.Id,
//              DepartmentId = department.Id,
//              FullName = employee.FirstName + " " + employee.LastName,
//              Salary = employee.AnnualSalary,
//              DepartmentName = department.LongName
//          };

//foreach (var res in resultsOfQuerySyntax)
//{
//    Console.WriteLine($"{res.FullName} (e-ID{res.EmployeeId}) works at  {res.DepartmentName} (departmentID- {res.DepartmentId}) and earns {res.Salary}");
//}

//transact sql-query
//SELECT
//   CONCAT (e.FirstName, '' ,e.LastName) AS FullName,
//   d.longName AS DepartmentName,
//FROM 
//  Department d
//INNER JOIN
//  Employee e
//ON
// d.Id = e.DepartmentId

// micorsoft recommends to use query syntax because its easeier to read and implement

var annualSalaryCompare = 200000;

//Determines whether all elements of a sequence satisfy a condition.
bool isTrueForAllEmployee = employeeList.All(e => e.AnnualSalary > annualSalaryCompare);
if(isTrueForAllEmployee)
{
    Console.WriteLine($"All employees annual salaries are above {annualSalaryCompare}");
}
else
{
    Console.WriteLine($" Not All employees annual salaries are above  {annualSalaryCompare}");
}

bool isTrueForAnyEmployee = employeeList.Any(emp => emp.AnnualSalary > annualSalaryCompare);
if (isTrueForAnyEmployee)
{
    Console.WriteLine($"Any one of employees have annual salaries are above {annualSalaryCompare}");
}
else
{
    Console.WriteLine($" Not Any one of employees have annual annual salaries are above  {annualSalaryCompare}");
}
//contains
var searchEmployee = new Employee()
{
    Id = 2,
    FirstName = "Sarah",
    LastName = "Jameson",
    AnnualSalary = 80000,
    IsManager = true,
    DepartmentId = 2
};

//bool containsEmployee = emloyeeList.Contains(searchEmployee);

bool containsEmployee  = employeeList.Contains(searchEmployee);

Console.WriteLine("is employee existing?"+containsEmployee); //return false
//objects ca be compared using IEqualityComparer
bool containsEmployeeByComparer = employeeList.Contains(searchEmployee, new EmployeeComparer());
Console.WriteLine("is employee by IEqualityComparer?"+ containsEmployeeByComparer); //return false


public class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        if(x.Id == y.Id && x.FirstName.ToLower() == y.FirstName.ToLower() && x.LastName == y.LastName)
        {
            return true;
        }
        return false;
    }

    public int GetHashCode([DisallowNull] Employee obj)
    {
        return obj.Id.GetHashCode();
    }
}



public static class EnumerableCollectionExtensionMethods
{
    public static IEnumerable<Employee> GetHigherSalariedEmployees(this IEnumerable<Employee> employees)
    {
        foreach(Employee emp in employees)
        {
            if(emp.AnnualSalary >= 50000)
            {
                yield return emp;  //yeild return instances one at a time, contiune the loop fromthe last return
            }
        }
    }
}
