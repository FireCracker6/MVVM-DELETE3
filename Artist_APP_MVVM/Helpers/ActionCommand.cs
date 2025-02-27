﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Artist_APP_MVVM.Helpers
{
    internal class ActionCommand : BaseCommand
    {
        private readonly Action<object> _action;
        private readonly Func<object, bool> _canExecute;

        public ActionCommand(Action<object> action) : this (action, null!)
        {
            
        }

        public ActionCommand(Action<object> action, Func<object, bool> canExecute) 
        {
            _action = action ?? throw new ArgumentException("action", "You must specify an Action<T>");
            _canExecute = canExecute;
        }

        public override void Execute(object? parameter)
        {
           _action(parameter!);
        }
    }
}
