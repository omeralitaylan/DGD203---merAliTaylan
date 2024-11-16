using System;

namespace CarSystem.Classes
{
    public class Performance
    {
        private double acceleration0To100;
        private int topSpeed;
        private double fuelEfficiency;
        private string driveMode;

        public Performance(double acceleration0To100, int topSpeed, double fuelEfficiency, string driveMode)
        {
            this.acceleration0To100 = acceleration0To100;
            this.topSpeed = topSpeed;
            this.fuelEfficiency = fuelEfficiency;
            this.driveMode = driveMode;
        }

        public override string ToString()
        {
            return $"0-100 km/h: {acceleration0To100}s, " +
                   $"Top Speed: {topSpeed} km/h, " +
                   $"Fuel Efficiency: {fuelEfficiency}L/100km, " +
                   $"Drive Mode: {driveMode}";
        }
    }
}
