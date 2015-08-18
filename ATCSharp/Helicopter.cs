using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{
    sealed class Helicopter : Aerodyne, Rotorcraft
    {

        public Helicopter() { }

        public Helicopter(Boolean moving, Boolean flying, Int32 speed, Int32 altitude) : base(moving, flying, speed, altitude) { }

        public override String takeOff()
        {

            return String.Format("Helicopter - Despegando!");

        } // takeOff

        public override String landing()
        {

            return String.Format("Helicopter - Aterrizando!");

        } // landing

        public String rotorcraftImplementation()
        {

            return String.Format("Implementando la caraterística de Ala rotatoria!");

        } // rotorcraftImplementation

        public String initApproachProcedureToPlatform(String platformNumber)
        {

            return String.Format("Iniciando procedimientos de aproximación hacia la plataforma {0}!", platformNumber);

        } // initApproachProcedureToPlatform

        public override string ToString()
        {

            return String.Format("Helicopter - Navegando");

        } // ToString

    } // Helicopter

} // ATCSharp
