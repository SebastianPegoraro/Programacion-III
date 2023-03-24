using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Rock : Element
    {
        public override bool isWinner(Element element)
        {
            return element.GetType() == typeof(Scissors);
        }
    }
}
