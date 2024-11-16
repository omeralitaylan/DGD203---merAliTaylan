using System;

namespace CarSystem.Classes
{
    public class Electronics
    {
        private bool hasNavigationSystem;
        private bool hasBluetoothConnectivity;
        private int speakerCount;
        private string displayType;

        public Electronics(bool hasNavigationSystem, bool hasBluetoothConnectivity, 
                         int speakerCount, string displayType)
        {
            this.hasNavigationSystem = hasNavigationSystem;
            this.hasBluetoothConnectivity = hasBluetoothConnectivity;
            this.speakerCount = speakerCount;
            this.displayType = displayType;
        }

        public override string ToString()
        {
            string features = $"{displayType} display, {speakerCount} speakers";
            if (hasNavigationSystem) features += ", Navigation System";
            if (hasBluetoothConnectivity) features += ", Bluetooth";
            return features;
        }
    }
}
