using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EmpMgmt
{
    internal class Employee
    {

        public int Eid { get; private set; }
        public string Ename { get; set; }
        public double Esalary { get; set; }
        public string Emptype
        {
            get
            {
                return Emptype;
            } 
            
            set
            {
                if (Emptype == "Permanent" || Emptype == "Contract")
                {
                    emptype=Emptype;
                }
                else
                {
                    emptype = "INVALID TYPE";
                }
            }
        }

        string emptype;
        public Employee(int id, string name, double salary,string etype)
        {
            Eid = id;
            Ename = name;
            Esalary=salary;
            Emptype = etype;
            
           // Console.WriteLine("Employee ctor");   
        }

        public void Display()
        {
           Console.WriteLine("Employee Id : " +Eid+ "Employee Name : " +Ename+ "Salary : " +Esalary);
        }
    }
}


