using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTechWhizz
{
    public class ArtificialScentDecorator : Decorator
    {
        public ArtificialScentDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Artificial Scent";
            this.m_Price = 3.0;
        }
    }
}
