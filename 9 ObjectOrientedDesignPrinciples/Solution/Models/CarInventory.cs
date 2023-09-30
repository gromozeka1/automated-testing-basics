namespace Solution.Models;

// Singleton класс для хранения информации об автомобилях
class CarInventory
{
    private static CarInventory instance;
    private readonly List<Car> cars = new();

    private CarInventory()
    {
    }

    public static CarInventory Instance => instance ??= new CarInventory();

    public void AddCar(Car car) => cars.Add(car);

    public int GetCarCount() => cars.Count;

    public int GetCarTypeCount()
    {
        HashSet<string> uniqueBrands = new HashSet<string>();
        foreach (Car car in cars)
        {
            uniqueBrands.Add(car.Brand);
        }

        return uniqueBrands.Count;
    }

    public decimal GetAveragePrice()
    {
        decimal totalPrice = 0;
        foreach (Car car in cars)
        {
            totalPrice += car.UnitPrice;
        }

        return totalPrice / cars.Count;
    }

    public decimal GetAveragePriceByBrand(string brand)
    {
        decimal totalPrice = 0;
        int count = 0;
        foreach (Car car in cars)
        {
            if (car.Brand.ToLower() == brand.ToLower())
            {
                totalPrice += car.UnitPrice;
                count++;
            }
        }

        return count > 0 ? totalPrice / count : 0;
    }
}