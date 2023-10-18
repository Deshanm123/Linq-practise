using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using TCPData;
using TCPExtensions;


List<string> omnivores = new List<string>(){ "Dog","Cat","Human","Dolphin"};
List<string> pets = new List<string>(){ "Dog","Cat","Spiders"};

var animals = omnivores.Union(pets);
foreach (var animal in animals)
{
    Console.WriteLine(animal);
}

Console.WriteLine("\n Employee Union ");

var employeeList = Data.GetEmployees();
employeeList.Add(
    new Employee()
    {
        Id = 11,
        FirstName = "Tom",
        LastName = "Riddle"
    }
);

var employeeListClone = Data.GetEmployees();
employeeListClone.Add(
     new Employee()
     {
         Id= 12,
         FirstName = "Sirius",
         LastName ="Black"
     }
    );
var result = employeeList.Union(employeeListClone,new EmployeeComparer() );
//var result =employeeList.Intersect(employeeListClone, new EmployeeComparer());
foreach (var employee in result)
{
    Console.WriteLine(employee.FirstName);
}


public class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
       if(x.Id == y.Id  && x.FirstName == y.FirstName && x.LastName == y.LastName)
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