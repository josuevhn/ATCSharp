using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{
    abstract class Aerostat : Aircraft
    {

        public Aerostat() : base() { }

        public Aerostat(Boolean moving, Boolean flying, Int32 speed, Int32 altitude) : base(moving, flying, speed, altitude) { }

        public abstract String takeOff();
        public abstract String landing();
        public abstract String gasBags();

        public abstract String initApproachProcedureToPlatform(String platformNumber);

    } // Aerostat

} // ATCSharp
