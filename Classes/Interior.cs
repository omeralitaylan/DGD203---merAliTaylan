using System;

namespace CarSystem.Classes
{
    public class Interior
    {
        private string seatMaterial;
        private string interiorColor;
        private bool hasClimateControl;
        private bool hasSunroof;

        public Interior(string seatMaterial, string interiorColor, bool hasClimateControl, bool hasSunroof)
        {
            this.seatMaterial = seatMaterial;
            this.interiorColor = interiorColor;
            this.hasClimateControl = hasClimateControl;
            this.hasSunroof = hasSunroof;
        }

        public override string ToString()
        {
            string features = $"{interiorColor} {seatMaterial} interior";
            if (hasClimateControl) features += ", Climate Control";
            if (hasSunroof) features += ", Sunroof";
            return features;
        }
    }
}
