using System.Collections.Generic;


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
    Id = 101,
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




public class Customer
{
    public int Id { get; set; }
    public string  customerName { get; set; }

    public decimal salary { get; set; }
}

