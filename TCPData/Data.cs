using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TCPData
{
    public static class Data
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            Employee employee = new Employee
            {
                Id = 1,
                FirstName = "Bob",
                LastName = "Jones",
                AnnualSalary = 60000,
                IsManager = true,
                DepartmentId = 1
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 2,
                FirstName = "Sarah",
                LastName = "Jameson",
                AnnualSalary = 80000,
                IsManager = true,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 3,
                FirstName = "Douglas",
                LastName = "Roberts",
                AnnualSalary = 40000,
                 IsManager = false,
                DepartmentId = 2
            };
            employees.Add(employee);
            employee = new Employee
            {
                Id = 4,
                FirstName = "Jane",
                LastName = "Stevens",
                AnnualSalary = 30000,
                IsManager = false,
                DepartmentId = 3
            };
            employees.Add(employee);

            return employees;
        }

        public static List<Department> GetDepartments(IEnumerable<Employee> employees)
        {
            List<Department> departments = new List<Department>();

            Department department = new Department
            {
                Id = 1,
                ShortName = "HR",
                LongName = "Human Resources",
                Employees = from emp in employees
                            where emp.DepartmentId == 1
                            select emp
            };
            departments.Add(department);
            department = new Department
            {
                Id = 2,
                ShortName = "FN",
                LongName = "Finance",
                Employees = from emp in employees
                            where emp.DepartmentId == 2
                            select emp
            };
            departments.Add(department);
            department = new Department
            {
                Id = 3,
                ShortName = "TE",
                LongName = "Technology",
                Employees = from emp in employees
                            where emp.DepartmentId == 3
                            select emp
            };
            departments.Add(department);

            return departments;
        }

        public static ArrayList GetHeterogeneousDataCollection()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add(100);
            arrayList.Add(3000);

            arrayList.Add("Bob Jones");
            arrayList.Add("David Goggins");

            arrayList.Add(new Employee()
            {
                Id = 2,
                FirstName = "Deshan",
                LastName = "Maduranga",
                AnnualSalary = 80000,
                IsManager = true,
                DepartmentId = 2
            });
            arrayList.Add(new Employee()
            {
                Id = 2,
                FirstName = "Tanushi",
                LastName = "Umaya",
                AnnualSalary = 80000,
                IsManager = true,
                DepartmentId = 2
            });
            return arrayList;
        }

    }
}
