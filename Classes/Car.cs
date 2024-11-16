using System;
using CarSystem.Interfaces;

namespace CarSystem.Classes
{
    public class Car : IVehicle
    {
        private Engine engine;
        private Transmission transmission;
        private Body body;
        private Wheels wheels;
        private Interior interior;
        private Brakes brakes;
        private Suspension suspension;
        private Electronics electronics;
        private Safety safety;
        private Performance performance;

        private bool isRunning;
        private double currentSpeed;
        private double fuelLevel;
        private string model;
        private int year;

        public Car(Engine engine, Transmission transmission, Body body, 
                   Wheels wheels, Interior interior, Brakes brakes, 
                   Suspension suspension, Electronics electronics, 
                   Safety safety, Performance performance,
                   string model = "Default", int year = 2023)
        {
            this.engine = engine;
            this.transmission = transmission;
            this.body = body;
            this.wheels = wheels;
            this.interior = interior;
            this.brakes = brakes;
            this.suspension = suspension;
            this.electronics = electronics;
            this.safety = safety;
            this.performance = performance;
            this.model = model;
            this.year = year;
            
            this.isRunning = false;
            this.currentSpeed = 0;
            this.fuelLevel = 100;
        }

        // IVehicle implementation
        public string GetVehicleType() => "Car";
        public string GetModel() => model;
        public int GetYear() => year;

        public Engine GetEngine() => engine;
        public Transmission GetTransmission() => transmission;
        public Body GetBody() => body;
        public Wheels GetWheels() => wheels;
        public Interior GetInterior() => interior;
        public Brakes GetBrakes() => brakes;
        public Suspension GetSuspension() => suspension;
        public Electronics GetElectronics() => electronics;
        public Safety GetSafety() => safety;
        public Performance GetPerformance() => performance;

        public void Start()
        {
            if (!isRunning)
            {
                isRunning = true;
                Console.WriteLine($"{model} engine started.");
            }
        }

        public void Stop()
        {
            if (isRunning)
            {
                isRunning = false;
                currentSpeed = 0;
                Console.WriteLine($"{model} engine stopped.");
            }
        }

        public void Accelerate()
        {
            if (isRunning && fuelLevel > 0)
            {
                currentSpeed += 10;
                fuelLevel -= 1;
                Console.WriteLine($"{model} accelerating. Current speed: {currentSpeed} km/h");
            }
        }

        public void Brake()
        {
            if (currentSpeed > 0)
            {
                currentSpeed = Math.Max(0, currentSpeed - 10);
                Console.WriteLine($"{model} braking. Current speed: {currentSpeed} km/h");
            }
        }

        public bool IsRunning() => isRunning;
        public double GetCurrentSpeed() => currentSpeed;
        public double GetFuelLevel() => fuelLevel;

        public void PrintDetails()
        {
            Console.WriteLine($"\n{year} {model} Specifications:");
            Console.WriteLine($"Status: {(isRunning ? "Running" : "Stopped")}");
            Console.WriteLine($"Current Speed: {currentSpeed} km/h");
            Console.WriteLine($"Fuel Level: {fuelLevel}%");
            Console.WriteLine($"Engine: {engine}");
            Console.WriteLine($"Transmission: {transmission}");
            Console.WriteLine($"Body: {body}");
            Console.WriteLine($"Wheels: {wheels}");
            Console.WriteLine($"Interior: {interior}");
            Console.WriteLine($"Brakes: {brakes}");
            Console.WriteLine($"Suspension: {suspension}");
            Console.WriteLine($"Electronics: {electronics}");
            Console.WriteLine($"Safety: {safety}");
            Console.WriteLine($"Performance: {performance}");
        }
    }
}
