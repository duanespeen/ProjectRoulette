using Microsoft.Extensions.Hosting;
using RandomNamePicker.Abstractions;
using RandomNamePicker.Commands;
using RandomNamePicker.Model;
using RandomNamePicker.Receiver;

namespace BackgroundServices
{
    public class RandomNameGame : BackgroundService
    {
        private readonly ICommandInvoker _commandInvoker;
        private readonly NameList _nameList;
        public RandomNameGame(ICommandInvoker commandInvoker)
        {
            _commandInvoker = commandInvoker;
            _nameList = new();
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            bool running = true;
            Console.WriteLine("Select an option: \n 1) Add name \n 2) Delete name \n 3) Undo \n 4) Redo \n 5) Print all names \n 6) Pick name \n 7) Exit");
            while (running)
            {

                int userInput = Convert.ToInt16(Console.ReadLine());
                string name;
                switch (userInput)
                {
                    case 1:
                        Console.WriteLine("\n Enter a name");
                        name = Console.ReadLine();
                        _commandInvoker.Execute(new AddName(_nameList, name));
                        break;
                    case 2:
                        Console.WriteLine("\n Enter a name to be deleted");
                        name = Console.ReadLine();
                        _commandInvoker.Execute(new DeleteName(_nameList, name));
                        break;
                    case 3:
                        _commandInvoker.Undo();
                        break;
                    case 4:
                        _commandInvoker.Redo();
                        break;
                    case 5:
                        Console.WriteLine("\n List of names: ");
                        foreach (string s in _nameList.GetNames())
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 6:
                        var pickedName = new PickedName();
                        _commandInvoker.Execute(new PickName(_nameList, pickedName));
                        Console.WriteLine(pickedName.Name);
                        break;
                    case 7:
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;
                }

            }
            return Task.CompletedTask;
        }
    }
}
