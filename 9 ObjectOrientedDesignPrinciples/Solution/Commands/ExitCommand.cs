using Solution.Interfaces;

namespace Solution.Commands;

class ExitCommand : ICommand
{
    public void Execute() => Environment.Exit(0);
}