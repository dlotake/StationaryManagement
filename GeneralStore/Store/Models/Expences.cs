using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Models
{
    public class Expences:Element
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    public class ExpencesDetails:Element
    {
        private Expences expences;

        public Expences Expences
        {
            get { return expences; }
            set { expences = value; }
        }

        private double amount;

        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }


    }
}
