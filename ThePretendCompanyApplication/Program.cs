using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TCPData;
using TCPExtensions;



var employeeList = Data.GetEmployees();
var departmentList = Data .GetDepartments();


//ArrayList mixedCollection  = Data.GetHeterogeneousDataCollection();
//var stringResult = from s in mixedCollection.OfType<string>()
//                   select s;

//var intResult = from i in mixedCollection.OfType<int>()
//                select i;



//Console.WriteLine("Analyzinf strings and writing it down");
//foreach(var item in stringResult)
//{
//    Console.WriteLine(item);
//}

//Console.WriteLine("Analyzing integers and writing it down");
//foreach (var item in intResult)
//{
//    Console.WriteLine(item);
//}


//var employeeResults = from d in mixedCollection.OfType<Employee>()
//                        select d;

//Console.WriteLine("Analyzing Emmployee Object5 and writing it down");
//foreach (var employee in employeeResults)
//{
//    Console.WriteLine($"{employee.FirstName} works and earns {employee.AnnualSalary}");
//}
//first employee


//ElementAt  - Returns the element at a specified index in a sequence.
var firstEmployee = employeeList.ElementAt(0);
Console.WriteLine($"first employee is {firstEmployee.FirstName} employee id {firstEmployee.Id}");
//if elemennt at x position is not vailable due to x position not exisiting exception is thrown 
//to avoid that  we use ElementAtOrDefault Method
int xPosition = 100;
var xEmployee = employeeList.ElementAtOrDefault(xPosition);

if(xEmployee == null)
    Console.WriteLine("Employee doesnt exist");
 else
    Console.WriteLine($"first employee is {xEmployee.FirstName} employee id {xEmployee.Id}");




