using RandomNamePicker.Abstractions;
using RandomNamePicker.Receiver;

namespace RandomNamePicker.Commands
{
    public class AddName : IUndoCommand
    {
        private NameList _nameList;
        private string _name;
        public AddName(NameList nameList, string name)
        {
            _nameList = nameList;
            _name = name;
        }
        public void Execute()
        {
            _nameList.AddName(_name);
        }

        public void Undo()
        {
            _nameList.DeleteName(_name);
        }

        public void Redo()
        {
            Execute();
        }
    }
}
