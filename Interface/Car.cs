using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class Car : ICompany, IVehicle
    {
        public bool HasTrunk { get; set; }
        public bool IsConvertible { get; set; }
        public int Wheels { get; set; }
        public int Windows { get; set; }
        public int Headlights { get; set; }
        public bool Honks { get; set; }
        public string Logo { get; set; }
        public string Name { get; set; }

        public void HonkNoise()
        {
            Console.WriteLine("implementation defined");

        }
    }
}
