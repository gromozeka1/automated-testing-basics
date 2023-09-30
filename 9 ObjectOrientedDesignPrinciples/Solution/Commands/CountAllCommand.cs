using Solution.Interfaces;
using Solution.Models;

namespace Solution.Commands;

// Команда для вывода общего количества автомобилей
class CountAllCommand : ICommand
{
    public void Execute()
    {
        int count = CarInventory.Instance.GetCarCount();
        Console.WriteLine($"Общее количество автомобилей: {count}");
    }
}