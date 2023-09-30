using Solution.Interfaces;
using Solution.Models;

namespace Solution.Commands;

// Команда для вывода средней стоимости автомобиля
class AveragePriceCommand : ICommand
{
    public void Execute()
    {
        decimal averagePrice = CarInventory.Instance.GetAveragePrice();
        Console.WriteLine($"Средняя стоимость автомобиля: {averagePrice:C}");
    }
}