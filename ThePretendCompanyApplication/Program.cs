using System.Runtime.Intrinsics.Arm;
using TCPData;

var employeeList =  Data.GetEmployees();
var departmentList = Data.GetDepartments(employeeList);

//logging the all the employee names in departments
//<IEnumerable<IEnumerable<Employee>>
var employeesInDep = departmentList.Select(dep => dep.Employees);

foreach(var dep in employeesInDep)
{
    foreach(var emp in dep)
    {
        Console.WriteLine(emp.FirstName + " " + emp.LastName);
    }
}

//logging the all the employee names in departments using select Many
var employeesinDep = departmentList.SelectMany(dep => dep.Employees);

foreach (var emp in employeesinDep)
{
    Console.WriteLine(emp.FirstName + " " + emp.LastName);
}