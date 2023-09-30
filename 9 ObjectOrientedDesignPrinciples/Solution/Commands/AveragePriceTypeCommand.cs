using Solution.Interfaces;
using Solution.Models;

namespace Solution.Commands;

// Команда для вывода средней стоимости автомобилей каждой марки

class AveragePriceTypeCommand : ICommand
{
    public void Execute()
    {
        Console.Write("Введите марку автомобиля: ");
        string brand = Console.ReadLine();
        decimal averagePrice = CarInventory.Instance.GetAveragePriceByBrand(brand);
        if (averagePrice > 0)
            Console.WriteLine($"Средняя стоимость автомобилей марки {brand}: {averagePrice:C}");
        else
            Console.WriteLine($"Марка {brand} не найдена в инвентаре.");
    }
}