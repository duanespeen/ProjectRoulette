﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNamePicker.Abstractions
{
    public interface ICommandInvoker
    {
        public void Execute(ICommand command);
        public void Undo();
        public void Redo();
    }
}
