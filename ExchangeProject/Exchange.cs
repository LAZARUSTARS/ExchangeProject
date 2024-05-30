using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeProject
{
    class Exchange
    {
        private int idStock;
        private string name;
        private string description;
        private string ticker;
        private string logo;
        private long currentCap;
        private decimal evebitda;
        private decimal[] price;

        public Exchange(int idStock, string name, string description, string ticker, string logo, long currentCap, decimal evebitda, decimal[] price)
        {
            this.idStock = idStock;
            this.name = name;
            this.description = description;
            this.ticker = ticker;
            this.logo = logo;
            this.currentCap = currentCap;
            this.evebitda = evebitda;
            this.price = price;
        }

        public int IdStock { get { return idStock; } set { idStock = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Ticker { get { return ticker; } set { ticker = value; } }
        public long CurrentCap { get { return currentCap; } set { currentCap = value; } }
        public decimal Evebitda { get { return evebitda; } set { evebitda = value; } }
        public decimal[] Price1 { get {  return price; } set {  price = value; } }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", name, description, ticker);
        }
    }
}
