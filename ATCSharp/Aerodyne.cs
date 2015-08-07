using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{

    abstract class Aerodyne : Aircraft
    {

        public Aerodyne() : base() { }

        public Aerodyne(Boolean moving, Boolean flying, Int32 speed, Int32 altitude) : base(moving, flying, speed, altitude) { }

        public abstract String takeOff();
        public abstract String landing();
        
    } // Aerodyne

} // ATCSharp
