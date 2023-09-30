﻿namespace Solution;

public class Car : AbstractVehicle
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
