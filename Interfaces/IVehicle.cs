using System;
using CarSystem.Classes;

namespace CarSystem.Interfaces
{
    public interface IVehicle
    {
        // Basic vehicle information
        string GetVehicleType();
        string GetModel();
        int GetYear();

        // Component access methods
        Engine GetEngine();
        Transmission GetTransmission();
        Body GetBody();
        Wheels GetWheels();
        Interior GetInterior();
        Brakes GetBrakes();
        Suspension GetSuspension();
        Electronics GetElectronics();
        Safety GetSafety();
        Performance GetPerformance();

        // Vehicle operations
        void Start();
        void Stop();
        void Accelerate();
        void Brake();
        
        // Status information
        bool IsRunning();
        double GetCurrentSpeed();
        double GetFuelLevel();

        // Display information
        void PrintDetails();
    }
}
