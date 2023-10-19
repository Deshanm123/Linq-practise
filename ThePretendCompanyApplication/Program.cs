using TCPData;

var employeeList =  Data.GetEmployees();


var results = from employee in employeeList
              let initials = employee.FirstName.Substring(0,1).ToUpper() + employee.LastName.Substring(0,1).ToUpper()
              let annualSalaryPlusBonus = employee.IsManager ? employee.AnnualSalary + employee.AnnualSalary * 0.6m : employee.AnnualSalary + employee.AnnualSalary * 0.4m
              select new
              {
                  Initials = initials,
                  FullName = employee.FirstName + "" + employee.LastName,
                  TotalEarnings = annualSalaryPlusBonus,
              };


foreach(var record in results)
{
    Console.WriteLine(record.Initials +" "+ record.FullName +" earns " +record.TotalEarnings);
}
