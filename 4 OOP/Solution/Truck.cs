namespace Solution;

class Truck : AbstractVehicle
{
    public int MaxCargoWeight { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("Truck Information:");
        base.DisplayInfo();
        Console.WriteLine($"Max Cargo Weight: {MaxCargoWeight}");
        Console.WriteLine();
    }
}
