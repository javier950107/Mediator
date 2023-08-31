using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class TextBox : Component
    {
        public TextBox(AuthenticationDialog _dialog) : base(_dialog)
        {
        }
    }
}
