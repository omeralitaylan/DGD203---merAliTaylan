using System;

namespace CarSystem.Classes
{
    public class Suspension
    {
        private string type;
        private bool isAdjustable;
        private double rideHeight;
        private string damperType;

        public Suspension(string type, bool isAdjustable, double rideHeight, string damperType)
        {
            this.type = type;
            this.isAdjustable = isAdjustable;
            this.rideHeight = rideHeight;
            this.damperType = damperType;
        }

        public override string ToString()
        {
            return $"{type} suspension" + 
                   (isAdjustable ? " (Adjustable)" : "") + 
                   $", {rideHeight}mm ride height, {damperType} dampers";
        }
    }
}
