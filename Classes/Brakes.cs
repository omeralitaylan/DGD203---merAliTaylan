using System;

namespace CarSystem.Classes
{
    public class Brakes
    {
        private string type;
        private bool hasABS;
        private bool hasTractionControl;
        private string brakePadMaterial;

        public Brakes(string type, bool hasABS, bool hasTractionControl, string brakePadMaterial)
        {
            this.type = type;
            this.hasABS = hasABS;
            this.hasTractionControl = hasTractionControl;
            this.brakePadMaterial = brakePadMaterial;
        }

        public override string ToString()
        {
            string features = $"{type} brakes with {brakePadMaterial} pads";
            if (hasABS) features += ", ABS";
            if (hasTractionControl) features += ", Traction Control";
            return features;
        }
    }
}
