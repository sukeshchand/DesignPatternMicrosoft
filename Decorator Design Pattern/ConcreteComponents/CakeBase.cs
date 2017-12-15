using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeTechWhizz
{
    public class CakeBase : BakeryComponent
    {
        // In real world these values will typically come from some data store
        private string m_Name = "Cake Regular";
        private double m_Price = 200.0;

        public override string GetName()
        {
            return m_Name;
        }

        public override double GetPrice()
        {
            return m_Price;
        }
    }
}
