using System;
using System.Collections.Generic;
using System.Text;



namespace _262256
{
    class Company
    {
       public List<Employee> firm = new List<Employee> { };
        public int FindEmployeeBySalary(int salary)
        {
            for (int i = 0; i < firm.Count; i++)
            {
                if (firm[i].Salary == salary) { return i; }
            }
            Console.WriteLine("Не е намерен");
            return -1;
        }//linejno ""
    }
}
