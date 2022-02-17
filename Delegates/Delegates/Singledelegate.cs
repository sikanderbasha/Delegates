using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
     class Singledelegate
    {
        delegate void Delegates(int x, int y);

        public void Delegate()
        {
            Delegates[] obj ={
                new Delegates(Output.Add),
                new Delegates(Output.Multiply)
            };

            for (int i = 0; i < obj.Length; i++)
            {
                obj[i](2, 3);
                obj[i](7, 9);
               
            }
        }
    }
}
