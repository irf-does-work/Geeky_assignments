using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpMgmt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(1,"Shyam",20000);
            Employee emp1 = new Employee(2,"Varsha",30000);
            Employee emp2 = new Employee(3,"Athul",35000);
            Employee emp3 = new Employee(4,"Lily",45000);

            Employee.DisplayEmpCount();
            emp.Display();
            emp1.Display();
            emp2.Display();
            emp3.Display();

        }

        internal class Employee
        {
            public Employee(int id)
            {
                empNo++;
                this.id = "Emp" + Convert.ToString(empNo + 1000);
            }

            public Employee(int id, string name) : this(id)
            {
                Name = name;
            }

            public Employee(int id, string name, double salary) : this(id, name)
            {
                Salary = salary;
            }


            static int empNo = -1;

            private string id;
            public string Id
            {
                get { return id; }
                set { id = value; }
            }
            public string Name { get; set; }
            public double Salary { get; set; }
            public string EmployeeType { get; set; }


            public static void DisplayEmpCount()
            {
                Console.WriteLine("Number of employees: " + (empNo + 1));
            }

            public void Display()
            {
                Console.WriteLine("EMPLOYEE ID: " + id);
                Console.WriteLine("EMPLOYEE NAME: " + Name);
                Console.WriteLine("SALARY: " + Salary);
                Console.WriteLine("");

            }
        }
    }
}
