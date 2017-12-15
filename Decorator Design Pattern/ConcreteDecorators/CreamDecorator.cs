using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTechWhizz
{
    public class CreamDecorator : Decorator
    {
        public CreamDecorator(BakeryComponent baseComponent)
            : base(baseComponent)
        {
            this.m_Name = "Cream";
            this.m_Price = 1.0;
        }
    }
}
