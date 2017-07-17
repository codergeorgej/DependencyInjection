using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection.Models
{
    public class Developer : Employee
    {
        public override void WhoAmI()
        {
            Console.WriteLine("I am a Developer");
        }
    }
}
