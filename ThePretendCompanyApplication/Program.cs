using System.Collections.Generic;
using TCPData;


Customer c1 = new Customer()
{
    Id = 101,
    customerName = "David Guetta",
    salary = 11500
};
Customer c2 = new Customer()
{
    Id = 102,
    customerName = "David Laid",
    salary = 10500
};
Customer c3 = new Customer()
{
    Id = 103,
    customerName = "David Goggins",
    salary = 12220
};

//creating a dictionary
//keys of a Dictionary must be unique
Dictionary<int, Customer> customerDictionary = new Dictionary<int, Customer>();
customerDictionary.Add(c1.Id, c1);
customerDictionary.Add(c2.Id, c2);
customerDictionary.Add(c3.Id, c3);

 //when adding or retreiving value from dictionary make sure to check it's keyy is existing or not if not you will run in to run time exception
if (customerDictionary.ContainsKey(104)) 
{
    customerDictionary.Add(104, new Customer { Id = 104, customerName = "David Summerfield",salary =15600});
}
else
{
    Console.WriteLine("key already existing please try another");
}

//accessing data in dictionary 
Customer customer101 = customerDictionary[101];
Console.WriteLine($"Id = {0} Name={1} Salary ={3} ", customerDictionary[101].Id, customerDictionary[101].customerName, customerDictionary[101].salary);


//iterating through Dictionary
foreach(KeyValuePair<int,Customer> cust in customerDictionary)
{
    Console.WriteLine($"Key {cust.Key}"); // key part in Key Value pair
    Customer customer = cust.Value;  //Value part in key Value pair
    Console.WriteLine($"Id {customer.Id} Name {customer.customerName} ");

}

Console.WriteLine("****");
Console.ReadKey();
Customer custInstance;
if (customerDictionary.TryGetValue(101,out custInstance))
{
   Console.WriteLine(custInstance.customerName +":"+ custInstance.salary);
}
else
{
    Console.WriteLine("The customer  is not found");
}
Console.WriteLine("Total items ={0}", customerDictionary.Count(kvp => kvp.Value.salary > 4000));


//Removing item from dictionary
customerDictionary.Remove(103);

//Array to Dictionary
Employee employee1 = new Employee
{
    Id = 1,
    FirstName = "Bob",
    LastName = "Jones",
    AnnualSalary = 60000,
    IsManager = true,
    DepartmentId = 1
};

Employee employee2 = new Employee
{
    Id = 2,
    FirstName = "Sarah",
    LastName = "Jameson",
    AnnualSalary = 80000,
    IsManager = true,
    DepartmentId = 2
};

Employee[] empArr = { employee1, employee2 };
Dictionary<int, Employee> employeeDictionary = empArr.ToDictionary(emp => emp.Id, emp => emp);
foreach(KeyValuePair<int,Employee> kvp in employeeDictionary)
{
    Console.WriteLine(kvp.Value.Id  +" "+ kvp.Value.FirstName);
}

//List
List<Department> departmentList = Data.GetDepartments();
Dictionary<int,Department> departmentDictionary =  departmentList.ToDictionary(dep => dep.Id, dep => dep);

foreach(KeyValuePair<int,Department> department in departmentDictionary)
{
    Console.WriteLine(department.Value.LongName );
}

public class Customer
{
    public int Id { get; set; }
    public string  customerName { get; set; }
    public decimal salary { get; set; }
}

