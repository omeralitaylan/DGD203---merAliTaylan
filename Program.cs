using System;
using CarSystem.Classes;
using CarSystem.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        // Create a sports car
        IVehicle sportsCar = new Car(
            new Engine(450, "V8", "Petrol", 4.0),
            new Transmission("Sport", 8, true),
            new Body("Coupe", "Red", 2, 1500),
            new Wheels(20, "Sport", "Performance", true),
            new Interior("Leather", "Black", true, true),
            new Brakes("Carbon Ceramic", true, true, "Performance"),
            new Suspension("Sport", true, 120, "Adaptive"),
            new Electronics(true, true, 12, "10-inch Touchscreen"),
            new Safety(6, true, true, true),
            new Performance(3.9, 300, 12.5, "Sport+"),
            "Ferrari 488", 2023
        );

        // Create a family SUV
        IVehicle familySUV = new Car(
            new Engine(190, "Inline-4", "Hybrid", 2.5),
            new Transmission("CVT", 6, true),
            new Body("SUV", "Silver", 5, 2000),
            new Wheels(18, "Comfort", "All-Season", true),
            new Interior("Fabric", "Beige", true, false),
            new Brakes("Disc", true, true, "Standard"),
            new Suspension("Comfort", false, 180, "Standard"),
            new Electronics(true, true, 8, "8-inch Touchscreen"),
            new Safety(8, true, true, true),
            new Performance(8.5, 180, 6.5, "Eco"),
            "Toyota RAV4", 2023
        );

        // Create a luxury sedan
        IVehicle luxurySedan = new Car(
            new Engine(320, "V6", "Petrol", 3.0),
            new Transmission("Luxury", 9, true),
            new Body("Sedan", "Black", 4, 1800),
            new Wheels(19, "Luxury", "Premium", true),
            new Interior("Premium Leather", "Brown", true, true),
            new Brakes("Disc", true, true, "Premium"),
            new Suspension("Comfort", true, 150, "Adaptive"),
            new Electronics(true, true, 16, "12-inch Touchscreen"),
            new Safety(10, true, true, true),
            new Performance(5.5, 250, 9.5, "Comfort"),
            "Mercedes E-Class", 2023
        );

        // Demonstrate vehicle operations
        Console.WriteLine("=== Vehicle Operations Demo ===");
        
        // Sports Car Demo
        Console.WriteLine("\nSports Car Operations:");
        sportsCar.PrintDetails();
        sportsCar.Start();
        for (int i = 0; i < 3; i++)
        {
            sportsCar.Accelerate();
        }
        sportsCar.Brake();
        sportsCar.Stop();
        sportsCar.PrintDetails();

        // Family SUV Demo
        Console.WriteLine("\nFamily SUV Operations:");
        familySUV.PrintDetails();
        familySUV.Start();
        familySUV.Accelerate();
        familySUV.Brake();
        familySUV.Stop();
        familySUV.PrintDetails();

        // Luxury Sedan Demo
        Console.WriteLine("\nLuxury Sedan Operations:");
        luxurySedan.PrintDetails();
        luxurySedan.Start();
        luxurySedan.Accelerate();
        luxurySedan.Accelerate();
        luxurySedan.Brake();
        luxurySedan.Stop();
        luxurySedan.PrintDetails();
    }
}
