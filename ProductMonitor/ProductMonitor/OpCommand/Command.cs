using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductMonitor.OpCommand
{
    public class Command : ICommand
    {
        private Action action;
        public event EventHandler? CanExecuteChanged;

        public Command(Action action)
        {
            this.action = action;
        }

        // 是否可以执行
        public bool CanExecute(object? parameter)
        {
            return true;
        }

        // 执行方法
        public void Execute(object? parameter)
        {
            if (action != null)
            {
                action();
            }
        }
    }
}
