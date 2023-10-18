using TCPData;

//to list operator
IEnumerable<Employee> Employees = from emp in Data.GetEmployees()
                                  where emp.AnnualSalary > 50000
                                  select emp;

List<Employee> employeeList = Employees.ToList();



//ToDictionary
Console.WriteLine("\n Dictionary");
Dictionary<int, Employee> dictionary = (from emp in employeeList where emp.AnnualSalary > 50000 select emp).ToDictionary<Employee, int>(e => e.Id);

foreach (var key in dictionary.Keys)
{
    Console.WriteLine($"Key : {key} Value : {dictionary[key].FirstName} {dictionary[key].LastName}" );
}

//ToArray
IEnumerable<Employee> result = from employee in employeeList
             where employee.AnnualSalary > 1000
             select employee;

Employee[] empArr = result.ToArray();

foreach(var emp in empArr)
{
    Console.WriteLine($"{emp.Id,10} - {emp.FirstName,30} ");
}


