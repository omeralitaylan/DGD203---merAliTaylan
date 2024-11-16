using System;

namespace CarSystem.Classes
{
    public class Wheels
    {
        private int size;
        private string type;
        private string tireType;
        private bool isAlloy;

        public Wheels(int size, string type, string tireType, bool isAlloy)
        {
            this.size = size;
            this.type = type;
            this.tireType = tireType;
            this.isAlloy = isAlloy;
        }

        public override string ToString()
        {
            return $"{size}\" {(isAlloy ? "Alloy" : "Steel")} {type} wheels with {tireType} tires";
        }
    }
}
