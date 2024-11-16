using System;

namespace CarSystem.Classes
{
    public class Transmission
    {
        private string type;
        private int gears;
        private bool isAutomatic;

        public Transmission(string type, int gears, bool isAutomatic)
        {
            this.type = type;
            this.gears = gears;
            this.isAutomatic = isAutomatic;
        }

        public override string ToString()
        {
            return $"{(isAutomatic ? "Automatic" : "Manual")} {type} {gears}-speed";
        }
    }
}
