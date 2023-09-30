namespace Solution;

/// <summary>
/// Drone
/// </summary>
/// <remarks>Restrictions:
/// Maximum flight distance for the drone is <see cref="maxFlightDistance"/> km
/// Each <see cref="flyTime"/> min of flight the drone stopped for <see cref="stopTime"/> min
/// </remarks>
public class Drone : IFlyable
{
    private readonly double speed = Helper.GetRandomValue(0, 20);
    private readonly double maxFlightDistance = 1000;
    private readonly int stopTime = 1;
    private readonly int flyTime = 10;

    public Coordinate CurrentPosition { get; private set; }

    public Drone(Coordinate initialPosition)
    {
        this.CurrentPosition = initialPosition;
    }

    public void FlyTo(Coordinate newPoint)
    {
        double distance = Helper.CalculateDistance(this.CurrentPosition, newPoint);
        if (distance > maxFlightDistance)
        {
            Console.WriteLine("Unable to fly such a long distance.");
            return;
        }

        this.CurrentPosition = newPoint;
    }

    public double GetFlyTime(Coordinate newPoint)
    {
        double distance = Helper.CalculateDistance(this.CurrentPosition, newPoint);
        double flyTime = distance / GenerateAdjustedSpeed(this.flyTime, this.stopTime);
        return Math.Round(flyTime, 2);
    }

    private double GenerateAdjustedSpeed(double flyTime, double stopTime)
    {
        double adjustedSpeed = flyTime / (flyTime + stopTime) * this.speed;
        return adjustedSpeed;
    }
}
