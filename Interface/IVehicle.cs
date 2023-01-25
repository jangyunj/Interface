using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal interface IVehicle
    {
        public int Wheels { get; set; }
        public int Windows { get; set; }
        public int Headlights { get; set; }
        public bool Honks { get; set; }
        public void HonkNoise();
    }
}
