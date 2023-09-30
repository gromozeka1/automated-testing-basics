using Solution;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объекты птицы, самолета и дрона
            Bird bird = new Bird(new Coordinate { X = 0, Y = 0, Z = 0 });
            Airplane airplane = new Airplane(new Coordinate { X = 0, Y = 0, Z = 0 });
            Drone drone = new Drone(new Coordinate { X = 0, Y = 0, Z = 0 });

            // Пример использования методов
            Coordinate newPoint = new Coordinate { X = 10, Y = 20, Z = 30 };

            double birdFlyTime = bird.GetFlyTime(newPoint);
            Console.WriteLine($"Время полета птицы до новой точки: {birdFlyTime} часов");
            bird.FlyTo(newPoint);

            double airplaneFlyTime = airplane.GetFlyTime(newPoint);
            Console.WriteLine($"Время полета самолета до новой точки: {airplaneFlyTime} часов");
            airplane.FlyTo(newPoint);

            double droneFlyTime = drone.GetFlyTime(newPoint);
            Console.WriteLine($"Время полета дрона до новой точки: {droneFlyTime} часов");
            drone.FlyTo(newPoint);

            Console.ReadLine();
        }
    }
}