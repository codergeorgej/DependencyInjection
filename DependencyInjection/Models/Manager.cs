using DependencyInjection.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Manager : Employee
    {
        IFinanceService _financeService;

        public Manager(IFinanceService financeService)
        {
            _financeService = financeService;
        }

        public override void WhoAmI()
        {
            _financeService.PrintName();
            Console.WriteLine("I am a Manager");
        }
    }
}
