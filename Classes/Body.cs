using System;

namespace CarSystem.Classes
{
    public class Body
    {
        private string bodyType;
        private string color;
        private int doors;
        private double weight;

        public Body(string bodyType, string color, int doors, double weight)
        {
            this.bodyType = bodyType;
            this.color = color;
            this.doors = doors;
            this.weight = weight;
        }

        public override string ToString()
        {
            return $"{color} {bodyType} ({doors}-door, {weight}kg)";
        }
    }
}
