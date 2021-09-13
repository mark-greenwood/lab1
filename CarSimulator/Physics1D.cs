using System;
namespace CarSimulator
{

    public class Physics1D
    {
        // Implement the methods
        public static double compute_position(double x0, double v, double dt)
        {
            return (x0 + v * dt); // This is the equation for position given original pos, vel and time
        }
        public static double compute_velocity(double v0, double a, double dt)
        {
            return (v0 + a * dt); // This is the equation for velocity given inital vel, accel and time
        }
        public static double compute_velocity(double x0, double t0, double x1, double t1)
        {
            return ((x1 - x0) / (t1 - t0)); // This is the equatlion for vel given inital pos, time and final pos, time.
        }
        public static double compute_acceleration(double v0, double t0, double v1, double t1)
        {
            return ((v1 - v0) - (t1 - t0)); // This is the equation for accel given inital vel, time and final vel time.
        }
        public static double compute_acceleration(double f, double m)
        {
            // to do
            return f / m; // Acceleration given force and mass
        }
    }
}
