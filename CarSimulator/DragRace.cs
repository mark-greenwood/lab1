using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSimulator
{
    public class DragRace
    {
        static void Main(string[] args)
        {

            Car myTesla = new Car("Tesla", 1500, 1000, 0.51);
           
            Car myPrius = new Car("Prius", 1000, 750, 0.43);

            // drive for 60 seconds with delta time of 1s
            /* double dt = 1;

             for (double t = 0; t < 60; t += dt)
             {
                 myTesla.Drive(t);
                 myPrius.Drive(t);

                 if (myTesla.myCarState.position > myPrius.myCarState.position)
                 {
                     Console.WriteLine("Leader: Tesla\n");
                 }
                 else if (myTesla.myCarState.position < myPrius.myCarState.position)
                 {
                     Console.WriteLine("Leader: Prius\n");
                 }
                 else if (myTesla.myCarState.position == myPrius.myCarState.position)
                 {
                     Console.WriteLine("Leader: Neither!\n");
                 }

                 Console.WriteLine("Time {0} ", t);
                 Console.WriteLine("Tesla State t:{0}, a:{1}, v:{2}, x1:{3}", myTesla.myCarState.time, myTesla.myCarState.acceleration, myTesla.myCarState.velocity, myTesla.myCarState.position);
                 Console.WriteLine("Prius State t:{0}, a:{1}, v:{2}, x1:{3}", myPrius.myCarState.time, myPrius.myCarState.acceleration, myPrius.myCarState.velocity, myPrius.myCarState.position);
                 // print the time and current state
                 // print who is in lead
            */
            
            double dt = 0.1;
            double t = 0;

             while(myTesla.myCarState.position < 402.3 || myPrius.myCarState.position < 402.3)
             {
                 myTesla.Drive(t);
                 myPrius.Drive(t);

                 Console.WriteLine("Time {0} ", t);
                 Console.WriteLine("Tesla State t:{0}, a:{1}, v:{2}, x1:{3}", myTesla.myCarState.time, myTesla.myCarState.acceleration, myTesla.myCarState.velocity, myTesla.myCarState.position);
                 Console.WriteLine("Prius State t:{0}, a:{1}, v:{2}, x1:{3}", myPrius.myCarState.time, myPrius.myCarState.acceleration, myPrius.myCarState.velocity, myPrius.myCarState.position);
                t += dt;
            }
           
            if (myTesla.myCarState.position > myPrius.myCarState.position)
            {
                Console.WriteLine("\nWinner: Tesla");
            }
            else if (myTesla.myCarState.position < myPrius.myCarState.position)
            {
                Console.WriteLine("\nWinner: Prius");
            }
            else if (myTesla.myCarState.position == myPrius.myCarState.position)
            {
                Console.WriteLine("\nWinner: Neither!");
            }

        }
    }
}
