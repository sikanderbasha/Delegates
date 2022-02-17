using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     class Multipledelegate
    {
        delegate void Delegates(int x, int y);

        public void Delegating()
        {
            Delegates obj = Output.Add;
            obj += Output.Multiply;

            obj(3, 9);
            obj(1, 5);
        }
    }
}
