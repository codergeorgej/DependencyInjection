using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Implementations
{
    public class FinanceService : IFinanceService
    {
        public void PrintName()
        {
            Console.WriteLine("Name written from FinanceService");
        }
    }
}
