namespace Solution;

class Bus : AbstractVehicle
{
    public int NumberOfSeats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("Car Information:");
        base.DisplayInfo();
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        Console.WriteLine();
    }
}