using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class MacFactory : IUIElementfactory
    {
        public IButton CreateButton()
        {
            return new MacButton();
        }

        public ITextbox CreateTextbox()
        {
            return new MacTextbox();
        }
    }
}
