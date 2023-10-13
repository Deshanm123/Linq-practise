using TCPData;
using TCPExtensions;

//Console.WriteLine("Employees ");
//List<Employee> employeeList = Data.GetEmployees(); 
////Custom method declared
//var filteredEmployee = employeeList.Filter(emp =>emp.IsManager == true); 
//var filteredEmployeeByLINQ = employeeList.Where(emp =>emp.IsManager == true);


//foreach (var employee in filteredEmployee)
//{
//    Console.WriteLine($"First Name: {employee.FirstName}");
//    Console.WriteLine($"Last Name : {employee.LastName}");
//    Console.WriteLine($"Annual Salary : {employee.AnnualSalary}");
//    Console.WriteLine($"Manager : {employee.IsManager}");
//    Console.WriteLine("");
//}

//Console.ReadKey();
//Console.WriteLine("Department");
//List<Department> departmentList = Data.GetDepartments();
//var filterDepartments = departmentList.Filter(dep => dep.ShortName == "HR" || dep.ShortName == "TE");
//foreach(var department in filterDepartments)
//{
//    Console.WriteLine($"Id : {department.Id}"); 
//    Console.WriteLine($"short Name : {department.ShortName}");
//    Console.WriteLine($"Long Name : {department.LongName}");
//    Console.WriteLine("");
//}

////Linq query Results
////Li0st<Employee> employeeList = Data.GetEmployees();
////List<Department> departmentList = Data.GetDepartments();
//Console.WriteLine("LINQ QUERIES");
//var resultList = from employee in employeeList
//                 join department in departmentList
//                 on employee.DepartmentId equals department.Id
//                 select new
//                 {
//                     FirstName = employee.FirstName,
//                     LastName = employee.LastName,
//                     AnnualSalary = employee.AnnualSalary,
//                     Manager = employee.IsManager,
//                     Department = department.LongName
//                 };
//Console.ReadKey();

//foreach( var result in resultList)
//{
//    Console.WriteLine($"{result.FirstName} works at {result.Department}");
//}

////above query will be like this
////SELECT
///// e.FirstName ,e.LastNamee,e.AnnualSalary ,e.IsManager , d.LongName
////FROM
////  Employee e 
////INNER JOIN
//// department d 
////ON 
////  e.DEpartmentId  = d.Id;


//Console.WriteLine("LINQ METHODS");
//var averageSalary = resultList.Average(emp => emp.AnnualSalary);
//Console.WriteLine($"average slary of  an employee is about {averageSalary}");

//var highestSalary = resultList.Max(emp => emp.AnnualSalary);
//var highestSalaryHolder = resultList.SingleOrDefault(emp => emp.AnnualSalary == highestSalary);

//Console.WriteLine($"{highestSalaryHolder.FirstName} {highestSalaryHolder.LastName} earnshigest salary which is  {highestSalary}");

//var lowestSal = resultList.Min(emp => emp.AnnualSalary);
//var lowestSalaryHolder = resultList.SingleOrDefault(emp=>emp.AnnualSalary == lowestSal).FirstName;
//Console.WriteLine($"{lowestSalaryHolder} earns the minimum salary ({lowestSal}) amounng other mates");


//List<Department> departmentList = Data.GetDepartments();
//List<Employee> employeelist = Data.GetEmployees();

//Console.WriteLine("Linq -Method Syntax");

//var employeeRecData = employeelist
//    .Select(e =>
//        new {
//            FullName = e.FirstName + " " + e.LastName,
//            Salary = e.AnnualSalary

//        })
//    .Where(e => e.Salary < 50000)
//    ;


//foreach (var employee in employeeRecData)
//{
//    Console.WriteLine($"{employee.FullName,15} earns {employee.Salary,10}");
//}
//Console.ReadKey();

//Console.WriteLine("Linq Query syntax");
//var EmployeeDatabyQuery = from emp in employeelist
//                          select new
//                          {
//                              FullName = emp.FirstName + " " + emp.LastName,
//                              Salary = emp.AnnualSalary
//                          };

//foreach(var emp in EmployeeDatabyQuery)
//{
//    Console.WriteLine(emp.FullName + " ->" + emp.Salary);
//}

//Console.WriteLine("employees that have graeater ssalaray than 50  k fetched by LINQqueries");

//var empAbvFifty = from emp in employeelist
//                  where emp.AnnualSalary > 50000
//                  select new
//                  {
//                      FullName = emp.FirstName + "" + emp.LastName,
//                      Salary = emp.AnnualSalary
//                  };

//due to dffereed execution we can add this record and expedcrt the record to be in the followiing  
// dataset 


//employeelist.Add(
//    new Employee
//    {  
//        FirstName  = "Deshan",
//        LastName = "Maduranga",
//        AnnualSalary = 100000,
//        IsManager = false,
//    }
//   );
//foreach(var emp in empAbvFifty)
//{
//    Console.WriteLine(emp.FullName + " ->" + emp.Salary);
//}



//In LINQ, queries have two different behaviors of execution: immediate and deferred.
//defered execution happen when you iterate simply,with in the for loop 

//DEFFRERD EXECUTION EXAMPLE
//List<Employee> employeeList = Data.GetEmployees();
//var results = from emp in employeeList.GetHigherSalariedEmployees()
//              select new
//              {
//                  FullName = emp.FirstName + " " + emp.LastName,
//                  AnnualSal = emp.AnnualSalary
//              };

//employeeList.Add(new Employee
//{
//    Id = 5,
//    FirstName = "Sam",
//    LastName = "David",
//    AnnualSalary = 100002,
//    IsManager = true,
//    DepartmentId = 2,
//});

//foreach (var emp in results)
//{
//    Console.WriteLine(emp.FullName + " ->" + emp.AnnualSal);
//}
/// indeffred execution query get executed during the iteration  therefeore ssam canbe found inthe result set


//Immediate execution
//var employeeList = Data.GetEmployees();
//var immediateExecutionResults = (from emp  in employeeList.GetHigherSalariedEmployees()
//                          select new
//                          {
//                              FullName = emp.FirstName + " " + emp.LastName,
//                              AnnualSal = emp.AnnualSalary
//                          }).ToList();


//employeeList.Add(new Employee
//{
//    Id = 5,
//    FirstName = "Sam",
//    LastName = "Immediate",
//    AnnualSalary = 100002,
//    IsManager = true,
//    DepartmentId = 2,
//});

//foreach (var emp in immediateExecutionResults)
//{
//    Console.WriteLine(emp.FullName + " ->" + emp.AnnualSal);
//}


//ineer join  by method syntax
//var employeeList  = Data.GetEmployees();
//var departmentList = Data.GetDepartments();
//var innerJoinResults = departmentList.Join(
//    employeeList, //outer join set
//    department => department.Id, // key oiin inner data set
//    employee => employee.DepartmentId,// outer key in outer dataset
//    (department, employee) => new
//    {
//        FullName = employee.FirstName + " " + employee.LastName,
//        DepartmentName = department.LongName
//    }
//    );

//foreach (var res in innerJoinResults)
//{
//    Console.WriteLine(res.FullName + "works at " +res.DepartmentName );
//}

//inner jin by query syntax
var employeeList = Data.GetEmployees();
var departmentList = Data.GetDepartments();

var innerJoinResultsByQuerySyntax =
     from emp in employeeList
     join dep in departmentList
     on emp.DepartmentId equals dep.Id
     select new
     {
         FullName = emp.FirstName +" "+emp.LastName,
         DepartmentName = dep.LongName
     };

foreach (var res in innerJoinResultsByQuerySyntax)
{
    Console.WriteLine(res.FullName + " works at " + res.DepartmentName);
}




public static class EnumerableCollectionExtensionMethods
{
    public static IEnumerable<Employee> GetHigherSalariedEmployees(this IEnumerable<Employee> employees)
    {
        foreach(Employee emp in employees)
        {
            if(emp.AnnualSalary >= 50000)
            {
                yield return emp;  //yeild return instances one at a time, contiune the loop fromthe last return
            }
        }
    }
}
