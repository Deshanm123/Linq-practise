using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TCPData;
using TCPExtensions;



var employeeList = Data.GetEmployees();
var departmentList = Data .GetDepartments();

//lastOrDefault
//returns the first element when the cindition iis successfully met otherwise it will return default value for the considered data type of that condition


List<int> oddIntegersList = new List<int>() {1,3,5,7,9 };
List<int> evenIntegersList = new List<int>() { 2, 4, 6, 8, 10 };


var lasteveninOddNumber = oddIntegersList.LastOrDefault(x => x % 2 == 0);
if (lasteveninOddNumber != 0)
    Console.WriteLine("odd number is  " + lasteveninOddNumber);
else
    Console.WriteLine("there are no odd numbers in the considered array liist");

var lastOddNumberinOddNumbers = oddIntegersList.LastOrDefault(x => x % 2 == 1);
if (lastOddNumberinOddNumbers != 0)
    Console.WriteLine("last odd Number is  " + lastOddNumberinOddNumbers);
else
    Console.WriteLine("there are no odd numbers in the considered array liist");
