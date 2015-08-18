using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{
    sealed class Airship : Aerostat
    {

        public Airship() : base() { }

        public Airship(Boolean moving, Boolean flying, Int32 speed, Int32 altitude) : base(moving, flying, speed, altitude) { }

        public override String takeOff()
        {

            return String.Format("Airship - Despegando!");

        } // takeOff

        public override String landing()
        {

            return String.Format("Airship - Aterrizando!");

        } // landing

        public override String gasBags()
        {

            return String.Format("Implementando la caraterística de bolsa de gas!");

        } // gasBags

        public override String initApproachProcedureToPlatform(String platformNumber)
        {

            return String.Format("Iniciando procedimientos de aproximación hacia la plataforma {0}!", platformNumber);

        } // initApproachProcedureToPlatform

        public override string ToString()
        {

            return String.Format("Airship - Navegando");

        } // ToString

    } // Airships

} // ATCSharp
