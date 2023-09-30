using Solution.Parts;

namespace Solution;

public abstract class AbstractVehicle
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public Engine Engine { get; set; }
    public Chassis Chassis { get; set; }
    public Transmission Transmission { get; set; }
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Model: {Model}");
        Console.WriteLine($"Manufacturer: {Manufacturer}");
        Console.WriteLine($"Engine Power: {Engine.Power}");
        Console.WriteLine($"Engine Volume: {Engine.Volume}");
        Console.WriteLine($"Engine Type: {Engine.Type}");
        Console.WriteLine($"Engine Serial Number: {Engine.SerialNumber}");
        Console.WriteLine($"Chassis Number of Wheels: {Chassis.NumberOfWheels}");
        Console.WriteLine($"Chassis Number: {Chassis.Number}");
        Console.WriteLine($"Chassis Max Load: {Chassis.MaxLoad}");
        Console.WriteLine($"Transmission Type: {Transmission.Type}");
        Console.WriteLine($"Transmission Number of Gears: {Transmission.NumberOfGears}");
        Console.WriteLine($"Transmission Manufacturer: {Transmission.Manufacturer}");

    }
}
