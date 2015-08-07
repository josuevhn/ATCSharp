using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{
    abstract class Aircraft
    {

        public Boolean moving { get; set; }
        public Boolean flying { get; set; }

        public Int32 speed { get; set; }
        public Int32 altitude { get; set; }

        public Aircraft() { }

        public Aircraft(Boolean moving, Boolean flying, Int32 speed, Int32 altitude)
        {

            this.moving = moving;
            this.flying = flying;

            this.speed = speed;
            this.altitude = altitude;

        } // Constructor

    } // Aircraft

} // ATCSharp
