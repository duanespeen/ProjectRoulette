using Microsoft.Extensions.Hosting;
using RandomNamePicker.Abstractions;
using RandomNamePicker.Commands;
using RandomNamePicker.Receiver;

namespace RandomNamePicker
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

        }
    }
}
