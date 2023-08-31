using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Checkbox : Component
    {

        private AuthenticationDialog _mediator;

        public Checkbox(AuthenticationDialog _dialog) : base(_dialog)
        {
            this._mediator = _dialog;
        }

        public void check()
        {
            this._mediator.notify(this, "check");
        }
    }
}
