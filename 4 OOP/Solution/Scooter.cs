namespace Solution;

public class Scooter : AbstractVehicle
{
    public int NumberOfSeats { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine("Scooter Information:");
        base.DisplayInfo();
        Console.WriteLine($"Number of Seats: {NumberOfSeats}");
        Console.WriteLine();
    }
}
