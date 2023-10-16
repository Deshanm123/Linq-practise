using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using TCPData;
using TCPExtensions;



var employeeList = Data.GetEmployees();
var departmentList = Data .GetDepartments();

//First firsOrDEfault 
//returns the first element when the cindition iis successfully met otherwise it will return default value for the considered data type of that condition


List<int> oddIntegersList = new List<int>() {1,3,5,7,9 };
List<int> evenIntegersList = new List<int>() { 2, 4, 6, 8, 10 };


var firseveninOddNumber = oddIntegersList.FirstOrDefault(x => x % 2 == 0);
if (firseveninOddNumber != 0)
    Console.WriteLine("odd number is  " + firseveninOddNumber);
else
    Console.WriteLine("there are no odd numbers in the considered array liist");

var firstEvenNumberInEven = evenIntegersList.FirstOrDefault(x => x% 2 == 0);
if (firstEvenNumberInEven != 0)
    Console.WriteLine("Even number is  " + firstEvenNumberInEven);
else
    Console.WriteLine("there are no odd numbers in the considered array liist");
