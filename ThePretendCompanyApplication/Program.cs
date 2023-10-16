using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using TCPData;
using TCPExtensions;




//SequenceEqual Evaluation as follows
////true if the two source sequences are of equal length and their corresponding elements are equal according to the default equality comparer for their type
//; otherwise, false.
List<int> oddIntegersList = new List<int>() {1,3,5,7,9 };

List<int> oddIntegersListClone = new List<int>() {1,3,5,7,9 };
var result = oddIntegersList.SequenceEqual(oddIntegersListClone);
Console.WriteLine("Is oddIntegers List is same Seqeunce as oddIntegersListClone ?" + result);

//var reverse = oddIntegersListClone.Reverse();
//var result2 = oddIntegersList.SequenceEqual();
oddIntegersListClone.Reverse();
var newResult = oddIntegersList.SequenceEqual(oddIntegersListClone);
Console.WriteLine("Is oddIntegers List is same Seqeunce as oddIntegersListClone but its rearranged in order ?" + newResult);

//comparing objects using sequence equal



var employeeList = Data.GetEmployees();
var employeeListClone = Data.GetEmployees();


Console.WriteLine("Comparing objects using SequenceEqual");

var employeeCompareResult= employeeList.SequenceEqual(employeeListClone);
Console.WriteLine(" employeeList and employeeListClone are two instancces of employee object but are they gonna equal  ?" + newResult);
//NO 

var empCompareByIEqualityComparer = employeeList.SequenceEqual(employeeListClone ,new EmployeeComparer());
Console.WriteLine(" \n employeeList and employeeListClone are two instancces of employee object but are they gonna equal  when using IequalityComparer ?" + empCompareByIEqualityComparer);


public class EmployeeComparer : IEqualityComparer<Employee>
{
    public bool Equals(Employee? x, Employee? y)
    {
        if(x.Id == y.Id  && x.FirstName.ToLower() == y.FirstName.ToLower()  && x.LastName == y.LastName)
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