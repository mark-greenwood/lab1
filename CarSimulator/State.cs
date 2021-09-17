using System;
namespace CarSimulator
{
    public class State
    {
        public double position;
        public double velocity;
        public double acceleration;
        public double time;

        public void set(double pos, double vel, double acc, double t)
        {
            position = pos;
            velocity = vel;
            acceleration = acc;
            time = t;
        }

        public State() // Initialize the variables to zero
        {
            position = 0;
            velocity = 0;
            acceleration = 0;
            time = 0;
         }

        public State(double pos, double vel, double acc, double t)
        {
            set(pos, vel, acc, t);
        }
    }
}
