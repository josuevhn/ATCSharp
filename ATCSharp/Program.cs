using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATCSharp
{

    class Program
    {

        static void Main(string[] args)
        {

            Console.WriteLine();

            Console.WriteLine("############   Detectando aeronaves en espacio aéreo   ############");

            // Creamos tres aeronaves, un avión, un helicoptero y un aeróstato.

            Airplane boeing737 = new Airplane();
            Helicopter kamovKA52 = new Helicopter();
            Airship zeppelinNT = new Airship();

            Console.WriteLine();

            // Establecemos parámetros por defecto y despegamos

            boeing737.moving = true;

            Console.WriteLine(boeing737.takeOff());

            boeing737.flying = true;
            boeing737.speed = 270;

            kamovKA52.moving = true;

            Console.WriteLine(kamovKA52.takeOff());

            kamovKA52.flying = true;
            kamovKA52.speed = 200;

            Console.WriteLine(zeppelinNT.gasBags());

            zeppelinNT.moving = true;

            Console.WriteLine(zeppelinNT.takeOff());

            zeppelinNT.flying = true;
            zeppelinNT.speed = 100;

            Console.WriteLine();

            // Representamos en el radar las aeronaves volando en nuestro espacio aéreo.

            Console.WriteLine("############   Representando la aeronaves en el radar   ############");

            Console.WriteLine();

            List<Aircraft> aircrafts = new List<Aircraft>();

            aircrafts.Add(boeing737);
            aircrafts.Add(kamovKA52);
            aircrafts.Add(zeppelinNT);

            foreach(Aircraft aircraft in aircrafts)
            {

                Console.WriteLine(aircraft);

                if(aircraft is Airplane)
                {

                    ((Airplane)aircraft).initApproachProcedureToRunway("L30");

                } // if
                else if(aircraft is Helicopter)
                {

                    ((Helicopter)aircraft).initApproachProcedureToPlatform("H10");

                } // else if
                else if(aircraft is Airship)
                {

                    ((Airship)aircraft).initApproachProcedureToPlatform("H11");

                } // else if

            } // foreach

            Console.WriteLine();

            // Aterrizamos las aeronaves

            Console.WriteLine("############   Aeronaves aterrizando   ############");

            Console.WriteLine();

            Console.WriteLine(boeing737.landing());
            Console.WriteLine(kamovKA52.landing());
            Console.WriteLine(zeppelinNT.landing());

            Console.WriteLine();

            Console.ReadKey();

        } // Main

    } // Program

}// ATCSharp
