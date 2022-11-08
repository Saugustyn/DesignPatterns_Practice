using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    internal class Application
    {
        private IUIElementfactory _uiElementfactory;

        public Application(IUIElementfactory uiElementfactory)
        {
            _uiElementfactory = uiElementfactory;
        }

        public void RenderUI()
        {

            var createNewFileButton = _uiElementfactory.CreateButton();
            createNewFileButton.Render();

            var textbox = _uiElementfactory.CreateTextbox();
            textbox.Render();
        }
    }
}
