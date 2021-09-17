using System;
using System.Linq;
using System.Collections.Generic;

namespace CarSimulator

{
    public class Highway
    {
        static void Main(string[] args)
        {
            int fleetNumberPerType = 25;
            //Step 1: implement fleets of arrays/lists per vehicle type
            // and compute states

            TeslaModel3[] myTeslas = Enumerable.Range(1, fleetNumberPerType).Select(TeslaModel3 => new TeslaModel3()).ToArray(); //TO DO: Projects each element of a sequence into a new form).ToArray();
            Prius[] myPriuses = Enumerable.Range(1, fleetNumberPerType).Select(Prius => new Prius()).ToArray(); //TO DO: Projects each element of a sequence into a new form).ToArray();
            Mazda3[] myMazda3s = Enumerable.Range(1, fleetNumberPerType).Select(Mazda3 => new Mazda3()).ToArray();
            Herbie[] myHerbies = Enumerable.Range(1, fleetNumberPerType).Select(Herbie => new Herbie()).ToArray();


            //Step 2: implement all the fleet in one list and compute states


            var myCars = new List<Car>();
            for (int i = 0; i < fleetNumberPerType; i++)
            {
                myCars.Add(new CarSimulator.TeslaModel3());
                myCars.Add(new CarSimulator.Prius());
                myCars.Add(new CarSimulator.Mazda3());
                myCars.Add(new CarSimulator.Herbie());
            // TO DO: Do the same for other class vehicles
            }
            // loop through the time and list to drive all the vehicles
            int dt = 1;
            for (double t = 0; t < 60; t += dt)
            {
                for (int i = 0; i < fleetNumberPerType*4; i++)
                {
                    myCars[i].Drive(t);
                    Console.WriteLine(i);
                   // TO DO: Drive myCars list and Display the cars states acceleration, speed, position, etc
                }
            }



        }

    }
}
