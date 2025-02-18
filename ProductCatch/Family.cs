using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatch
{
    public class Family
    {
    }

    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }

    }

    public class Man : Person
    {
        public Man()
        {
            
        }
        public string FreeTravelBy { get; set; }
    }

    public class Woman : Person
    {
        public string FreeTravelByBus { get; set; }

    }
}
