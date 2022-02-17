using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter 1 for single delegation program :");
            Console.WriteLine("Enter 2 for Multiple delegation program :");

            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Singledelegate delegates = new Singledelegate();
                    delegates.Delegate();
                    break;
                case 2:
                    Multipledelegate delegatemul = new Multipledelegate();
                    delegatemul.Delegating();
                    break;

                default:
                    Console.WriteLine("Select right number");
                    break;
            }
        }
    }
}
