using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Component
    {
        private AuthenticationDialog dialog;

        public Component(AuthenticationDialog _dialog)
        {
            this.dialog = _dialog;
        }

        public void click()
        {
            this.dialog.notify(this, "click");
        }

        public void keyPress()
        {
            this.dialog.notify(this, "keypress");
        }
    }
}
