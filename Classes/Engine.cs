using System;

namespace CarSystem.Classes
{
    public class Engine
    {
        private int horsepower;
        private string engineType;
        private string fuelType;
        private double displacement;

        public Engine(int horsepower, string engineType, string fuelType, double displacement)
        {
            this.horsepower = horsepower;
            this.engineType = engineType;
            this.fuelType = fuelType;
            this.displacement = displacement;
        }

        public override string ToString()
        {
            return $"{engineType} {displacement}L ({horsepower}hp, {fuelType})";
        }
    }
}
