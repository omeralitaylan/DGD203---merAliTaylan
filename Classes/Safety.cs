using System;

namespace CarSystem.Classes
{
    public class Safety
    {
        private int airbagCount;
        private bool hasLaneAssist;
        private bool hasBlindSpotMonitor;
        private bool hasEmergencyBraking;

        public Safety(int airbagCount, bool hasLaneAssist, bool hasBlindSpotMonitor, 
                     bool hasEmergencyBraking)
        {
            this.airbagCount = airbagCount;
            this.hasLaneAssist = hasLaneAssist;
            this.hasBlindSpotMonitor = hasBlindSpotMonitor;
            this.hasEmergencyBraking = hasEmergencyBraking;
        }

        public override string ToString()
        {
            string features = $"{airbagCount} airbags";
            if (hasLaneAssist) features += ", Lane Assist";
            if (hasBlindSpotMonitor) features += ", Blind Spot Monitor";
            if (hasEmergencyBraking) features += ", Emergency Braking";
            return features;
        }
    }
}
