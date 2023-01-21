using RandomNamePicker.Abstractions;
using RandomNamePicker.Model;
using RandomNamePicker.Receiver;

namespace RandomNamePicker.Commands
{
    public class PickName : ICommand
    {
        private readonly NameList _nameList;
        private readonly PickedName _pickedName;

        public PickName(NameList nameList, PickedName pickedName)
        {
            _nameList = nameList;
            _pickedName = pickedName;
        }
        
        public void Execute()
        {
            Random a = new();
            var listOfNames = _nameList.GetNames();
            if (!listOfNames.Any()) return;
            var index = a.Next(0, listOfNames.Count());
            _pickedName.Name = listOfNames.ElementAt(index);
        }
    }
}
