namespace Solution;

/// <summary>
/// Airplane
/// </summary>
/// <remarks>Restrictions:
/// Initial speed see <see cref="initialSpeed"/>.
/// Airplane's speed increased by <see cref="deltaSpeed"/> km/h every <see cref="deltaDistanceToChangeSpeed"/> km of the flight from the initial speed
/// </remarks>
public class Airplane : IFlyable
{
    private readonly double initialSpeed = 200;
    private readonly int deltaSpeed = 10;
    private readonly int deltaDistanceToChangeSpeed = 10;

    public Coordinate CurrentPosition { get; private set; }

    public Airplane(Coordinate initialPosition)
    {
        this.CurrentPosition = initialPosition;
    }

    public void FlyTo(Coordinate newPoint)
    {
        this.CurrentPosition = newPoint;
    }

    public double GetFlyTime(Coordinate newPoint)
    {
        double distance = Helper.CalculateDistance(this.CurrentPosition, newPoint);

        double speed = initialSpeed + (this.deltaSpeed * Math.Floor(distance / this.deltaDistanceToChangeSpeed));

        double flyTime = distance / speed;
        return Math.Round(flyTime, 2);
    }
}
