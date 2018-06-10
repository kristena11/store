using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GatesCandy
{
    public class Chocolate
    {
        #region Fields
        public string flavor;
        public double cost;
        public decimal quantity;

        #endregion End of Fields

        #region Constructors 
        public Chocolate(string flavor, double cost, decimal quantity)
        {
            this.flavor = flavor;
            this.cost = cost;
            this.quantity = quantity;
        }
        #endregion End of Constructors

    }
}
