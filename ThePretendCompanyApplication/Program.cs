using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TCPData;
using TCPExtensions;


//concatanattion f list

List<int> oddIntegersList = new List<int>() {1,3,5,7,9 };

List<int> evenIntegersList = new List<int>() {2,4,6,8, };


var numberList = oddIntegersList.Concat(evenIntegersList);
foreach (var number in numberList)
{
    Console.WriteLine(number);
}



//Employee 

 List<Employee> employees = Data.GetEmployees();

List<Employee> newEmployeesList = new List<Employee>()
{
    new Employee{Id = 90 , FirstName="Jack", LastName="Sparrrow"},
    new Employee{Id= 91,FirstName ="Davy",LastName="Johnson"}
};

employees.Concat(newEmployeesList);


foreach (var employee in employees)
{
    Console.WriteLine(employee.FirstName +" - " + employee.LastName);
}