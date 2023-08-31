using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal interface Mediator
    {
        public void notify(Component sender, string evt);
    }
}
