using Solution.Interfaces;
using Solution.Models;

namespace Solution.Commands;

class CountTypesCommand : ICommand
{
    public void Execute()
    {
        int count = CarInventory.Instance.GetCarTypeCount();
        Console.WriteLine($"Количество марок автомобилей: {count}");
    }
}