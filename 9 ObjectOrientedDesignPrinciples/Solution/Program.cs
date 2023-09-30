using Solution.Commands;
using Solution.Interfaces;
using Solution.Models;

namespace Solution;

public class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            PrintWelcomeMessage();
            
            var brand = GetUserInput("Марка");
            var model = GetUserInput("Модель");
            var quantity = GetQuantity();
            var unitPrice = GetUnitPrice();

            var car = new Car { Brand = brand, Model = model, Quantity = quantity, UnitPrice = unitPrice };
            CarInventory.Instance.AddCar(car);

            Console.WriteLine("Введите команду (count types, count all, average price, average price type, exit):");
            var command = Console.ReadLine().ToLower();

            ICommand commandObject;

            switch (command)
            {
                case "count types":
                    commandObject = new CountTypesCommand();
                    break;
                case "count all":
                    commandObject = new CountAllCommand();
                    break;
                case "average price":
                    commandObject = new AveragePriceCommand();
                    break;
                case "average price type":
                    commandObject = new AveragePriceTypeCommand();
                    break;
                case "exit":
                    commandObject = new ExitCommand();
                    break;
                default:
                    Console.WriteLine("Недопустимая команда.");
                    continue;
            }

            commandObject.Execute();
        }
    }

    private static void PrintWelcomeMessage()
    {
        Console.WriteLine("Введите информацию об автомобиле (марка, модель, количество, стоимость одной единицы):");
    }

    private static decimal GetUnitPrice()
    {
        decimal unitPrice;
        string input;
        do
        {
            Console.Write("Стоимость одной единицы: ");
            input = Console.ReadLine();
        }
        while (decimal.TryParse(input, out unitPrice));

        return unitPrice;
    }

    private static int GetQuantity()
    {
        int quantity;
        string input;
        do
        {
            Console.Write("Количество: ");
            input = Console.ReadLine();
        }
        while (int.TryParse(input, out quantity));

        return quantity;
    }

    private static string GetUserInput(string parameter)
    {
        Console.Write($"{parameter}: ");
        return Console.ReadLine();
    }
}