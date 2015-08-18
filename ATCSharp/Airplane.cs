using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{
    sealed class Airplane : Aerodyne, FixedWing
    {

        public Airplane() { }

        public Airplane(Boolean moving, Boolean flying, Int32 speed, Int32 altitude) : base(moving, flying, speed, altitude) { }

        public override String takeOff()
        {

            return String.Format("Airplane - Despegando!");

        } // takeOff

        public override String landing()
        {

            return String.Format("Airplane - Aterrizando!");

        } // landing

        public String fixedWingImplementation()
        {

            return String.Format("Implementando la caraterística de Ala Fija!");

        } // fixedWingImplementation

        public String initApproachProcedureToRunway(String runwayNumber)
        {

            return String.Format("Iniciando procedimientos de aproximación hacia la pista {0}!", runwayNumber);

        } // initApproachProcedureToRunway

        public override string ToString()
        {

            return String.Format("Airplane - Navegando");

        } // ToString

    } // Airplane

} // ATCSharp
