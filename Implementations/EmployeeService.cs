using DependencyInjection.Interfaces;
using DependencyInjection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Implementations
{
    public class EmployeeService<T> : IEmployeeService<T> where T:Employee
    {
        T _employee;
        public EmployeeService(T employee)
        {
            _employee = employee;
        }

        public void PrintName()
        {
            Console.WriteLine("Name written from EmployeeService");
        }

        public void PrintWhoAmI()
        {
            _employee.WhoAmI();
        }
    }
}
