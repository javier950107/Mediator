using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class AuthenticationDialog : Mediator
    {
        private Checkbox loginOrRegisterChkbx;
        private TextBox loginUsername;
        private Button okBtn;

        public AuthenticationDialog()
        {

        }
        public void notify(Component sender, string evt)
        {

            if (evt == "check")
            {
                Console.WriteLine("Llama al checkbox con event "+evt);

            }

            if(evt == "keypress")
            {
                Console.WriteLine("llama al textbox con event " + evt);
            }

            if(evt == "click")
            {
                Console.WriteLine("Llama al button con event " + evt);
            }
        }
    }
}
