using TCPData;

var employeeList =  Data.GetEmployees();

//into keyword

var results = from emp in employeeList
              where emp.AnnualSalary > 50000
              select emp
              into Highearners
              where Highearners.IsManager == true
              select Highearners;


foreach (var result in results)
{
    Console.WriteLine(result.FirstName , result.IsManager );
}