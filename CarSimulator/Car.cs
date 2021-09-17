using System;
namespace CarSimulator
{
   
    public class Car
    {
        protected double mass;
        protected string model;
        protected double dragArea;
        protected double engineForce;
        public State myCarState;

        protected double rho = 1.225; // Air Desnity from Lab Readme
        protected double net_force; // Net force engine force = drag force
        protected double fd,a,v,x1; // Drag force

        /// implement constructor and methods
        /// 
        public Car() 
        {
            myCarState = new State();
        }
        public Car(string mdl, double m, double engf, double dragA)// initalize the default
        {
            mass = m;
            model = mdl;
            dragArea = dragA;
            engineForce = engf;
            myCarState = new State();
        }

        public virtual void Drive(double dt)
        {
            fd = 0.5 * rho * dragArea * myCarState.velocity * myCarState.velocity; // This is the drag force per lab readme  

            net_force = engineForce - fd; // This is the interated net force
            a = CarSimulator.Physics1D.compute_acceleration(net_force, mass); // Calling compute_accel to find accel

            v = CarSimulator.Physics1D.compute_velocity(myCarState.velocity, myCarState.acceleration, dt);

            x1 = CarSimulator.Physics1D.compute_position(myCarState.position, myCarState.velocity, dt);

           myCarState.set(x1,v,a,dt); // update state
           Console.WriteLine("{4} State t:{0}, a:{1}, v:{2}, x1:{3}", myCarState.time, myCarState.acceleration, myCarState.velocity, myCarState.position, model);
        }
        //implement inheritence
        
        

    }
    public class TeslaModel3 : Car
    {
        public TeslaModel3() : base()
        {
            this.model = "TeslaModel3";
            this.mass = 1500;
            this.engineForce = 1000;
            this.dragArea = 0.51;
        }
        public TeslaModel3(string mod, double mas, double ef, double da)
        {
            this.model = mod;
            this.mass = mas;
            this.engineForce = ef;
            this.dragArea = da;
        }
    }
    public class Prius : Car
    {
        public Prius() : base()
        {
            model = "Prius";
            mass = 1000;
            engineForce = 750;
            dragArea = 0.43;
        }
        public Prius(string mod, double mas, double ef, double da)
        {
            model = mod;
            mass = mas;
            engineForce = ef;
            dragArea = da;
        }
    }


    public class Mazda3 : Car
    {
        public Mazda3() : base()
        {
            model = "Mazda3";
            mass = 1200;
            engineForce = 700;
            dragArea = 0.49;
        }
        public Mazda3(string mod, double mas, double ef, double da)
        {
            model = mod;
            mass = mas;
            engineForce = ef;
            dragArea = da;
        }
    }

    public class Herbie : Car
    {
        public Herbie() : base()
        {
            model = "Herbie";
            mass = 1;
            engineForce = 10000;
            dragArea = 0.01;
        }
        public Herbie(string mod, double mas, double ef, double da)
        {
            model = mod;
            mass = mas;
            engineForce = ef;
            dragArea = da;
        }

        public override void Drive(double dt)
        {
            fd = 0; // This is the drag force per lab readme  

            net_force = engineForce - fd; // This is the interated net force
            a = CarSimulator.Physics1D.compute_acceleration(net_force, mass); // Calling compute_accel to find accel

            v = CarSimulator.Physics1D.compute_velocity(myCarState.velocity, myCarState.acceleration, dt);

            x1 = CarSimulator.Physics1D.compute_position(myCarState.position, myCarState.velocity, dt);

            myCarState.set(x1, v, a, dt); // update state             
            Console.WriteLine("{4} State t:{0}, a:{1}, v:{2}, x1:{3}", myCarState.time, myCarState.acceleration, myCarState.velocity, myCarState.position, model);

        }
    }
}
