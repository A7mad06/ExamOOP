using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Employee:ICloneable,IComparable
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Salary { get; set; }

        public Employee()
        {

        }
        public Employee(Employee emp)
        {
            Id = emp.Id;
            Name = emp.Name;
            Salary = emp.Salary;
        }
        public object Clone()
        {
            return new Employee(this);
        }

        public override string ToString()
        {
            return $"Id:{Id},Name:{Name},Salary:{Salary}";
        }

        public int CompareTo(object? obj)
        {
            Employee? e = (Employee?)obj;
            if(this.Salary > e?.Salary)
            {
                return 1;
            }
            else if (Salary < e?.Salary)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
