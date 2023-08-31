using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Application
    {
        public static void Main(string[] args)
        {
            AuthenticationDialog dialog = new AuthenticationDialog();

            Button okButton = new Button(dialog);
            Checkbox checkbox = new Checkbox(dialog);
            TextBox textBox = new TextBox(dialog);
            // si quiero agregar otro componente solo es cuestion de agregar uno nuevo y configurar el mediador

            okButton.click();
            checkbox.check();
            textBox.keyPress();
        }
    }
}
