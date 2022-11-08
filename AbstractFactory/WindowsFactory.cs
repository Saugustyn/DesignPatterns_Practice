using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class WindowsFactory : IUIElementfactory
    {
        public IButton CreateButton()
        {
            return new WindowsButton();
        }

        public ITextbox CreateTextbox()
        {
            return new WindowsTextbox();
        }
    }
}
