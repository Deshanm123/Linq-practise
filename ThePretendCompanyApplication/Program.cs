using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TCPData;
using TCPExtensions;



//ineer join  by method syntax
var employeeList = Data.GetEmployees();
var departmentList = Data .GetDepartments();


ArrayList mixedCollection  = Data.GetHeterogeneousDataCollection();
var stringResult = from s in mixedCollection.OfType<string>()
                   select s;

var intResult = from i in mixedCollection.OfType<int>()
                select i;



Console.WriteLine("Analyzinf strings and writing it down");
foreach(var item in stringResult)
{
    Console.WriteLine(item);
}

Console.WriteLine("Analyzing integers and writing it down");
foreach (var item in intResult)
{
    Console.WriteLine(item);
}


var employeeResults = from d in mixedCollection.OfType<Employee>()
                        select d;

Console.WriteLine("Analyzing Emmployee Object5 and writing it down");
foreach (var employee in employeeResults)
{
    Console.WriteLine($"{employee.FirstName} works and earns {employee.AnnualSalary}");
}



