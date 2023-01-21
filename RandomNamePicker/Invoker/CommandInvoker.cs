using RandomNamePicker.Abstractions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNamePicker.Invoker
{
    public class CommandInvoker : ICommandInvoker
    {

        private readonly Stack<IUndoCommand> _undoStack;
        private readonly Stack<IUndoCommand> _redoStack;

        public CommandInvoker()
        {
            _undoStack = new Stack<IUndoCommand>();
            _redoStack = new Stack<IUndoCommand>();
        }

        public void Execute(ICommand command)
        {
            command.Execute();
            if (command is IUndoCommand undoCommand)
            {
                _undoStack.Push(undoCommand);
            }
        }
        public void Undo()
        {
            if (_undoStack.Count > 0)
            {
                var command = _undoStack.Pop();
                command.Undo();
                _redoStack.Push(command);
            }
        }

        public void Redo()
        {
            if (_redoStack.Count > 0)
            {
                var command = _redoStack.Pop();
                command.Execute();
                _undoStack.Push(command);
            }
        }
    }
}
