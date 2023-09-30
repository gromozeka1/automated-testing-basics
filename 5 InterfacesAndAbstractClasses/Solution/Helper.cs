namespace Solution;

internal static class Helper
{
    internal static double CalculateDistance(Coordinate point1, Coordinate point2)
    {
        double distance = Math.Sqrt(Math.Pow(point2.X - point1.X, 2) +
                                    Math.Pow(point2.Y - point1.Y, 2) +
                                    Math.Pow(point2.Z - point1.Z, 2));
        return distance;
    }

    internal static double GetRandomValue(double min, double max)
    {
        Random random = new Random();
        double speed = (random.NextDouble() * (max - min)) + min;
        return speed;
    }
}
