using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Element
    {
        private string option;

        public string Option { get => option; set => option = value; }

        public abstract bool isWinner(Element element);
    }
}
