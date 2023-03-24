using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Paper : Element
    {
        public override bool isWinner(Element element)
        {
            return element.GetType() == typeof(Rock);
        }
    }
}
