using DependencyInjection.Implementations;
using DependencyInjection.Interfaces;
using DependencyInjection.Models;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            //container.RegisterType<IEmployeeService, FinanceService>();
            container.RegisterTypes(AllClasses.FromLoadedAssemblies(), s=> { return WithMappings.FromAllInterfaces(s).Where(s1 => s1.FullName.Contains("IEmployeeService")); }, WithName.Default);
            //var test = WithMappings.FromAllInterfaces(typeof(FinanceService));
            var instance = container.Resolve<IEmployeeService<Developer>>();

            instance.PrintName();
            instance.PrintWhoAmI();
        }
    }
}
