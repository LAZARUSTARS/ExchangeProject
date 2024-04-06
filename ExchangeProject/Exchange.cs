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
        private int currentCap;
        private decimal evebitda;
        private decimal price1;
        private decimal price2;
        private decimal price3;
        private decimal price4;
        private decimal price5;
        private decimal price6;
        private decimal price7;
        private decimal price8;
        private decimal price9;
        private decimal price10;
        private decimal price11;
        private decimal price12;
        private decimal price13;
        private decimal price14;
        private decimal price15;
        private decimal price16;
        private decimal price17;
        private decimal price18;
        private decimal price19;
        private decimal price20;

        public Exchange(int idStock, string name, string description, string ticker, string logo, int currentCap, decimal evebitda, decimal price1, decimal price2, decimal price3, decimal price4, decimal price5, decimal price6, decimal price7, decimal price8, decimal price9, decimal price10, decimal price11, decimal price12, decimal price13, decimal price14, decimal price15, decimal price16, decimal price17, decimal price18, decimal price19, decimal price20)
        {
            this.idStock = idStock;
            this.name = name;
            this.description = description;
            this.ticker = ticker;
            this.logo = logo;
            this.currentCap = currentCap;
            this.evebitda = evebitda;
            this.price1 = price1;
            this.price2 = price2;
            this.price3 = price3;
            this.price4 = price4;
            this.price5 = price5;
            this.price6 = price6;
            this.price7 = price7;
            this.price8 = price8;
            this.price9 = price9;
            this.price10 = price10;
            this.price11 = price11;
            this.price12 = price12;
            this.price13 = price13;
            this.price14 = price14;
            this.price15 = price15;
            this.price16 = price16;
            this.price17 = price17;
            this.price18 = price18;
            this.price19 = price19;
            this.price20 = price20;
        }

        public int IdStock { get { return idStock; } set { idStock = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Ticker { get { return ticker; } set { ticker = value; } }
        public int CurrentCap { get { return currentCap; } set { currentCap = value; } }
        public decimal Evebitda { get { return evebitda; } set { evebitda = value; } }
        public decimal Price1 { get {  return price1; } set {  price1 = value; } }
        public decimal Price2 { get {  return price2; } set {  price2 = value; } }
        public decimal Price3 { get {  return price3; } set {  price3 = value; } }
        public decimal Price4 { get {  return price4; } set {  price4 = value; } }
        public decimal Price5 { get {  return price5; } set {  price5 = value; } }
        public decimal Price6 { get {  return price6; } set {  price6 = value; } }
        public decimal Price7 { get {  return price7; } set {  price7 = value; } }
        public decimal Price8 { get {  return price8; } set {  price8 = value; } }
        public decimal Price9 { get {  return price9; } set {  price9 = value; } }
        public decimal Price10 { get {  return price10; } set {  price10 = value; } }
        public decimal Price11 { get {  return price11; } set {  price11 = value; } }
        public decimal Price12 { get {  return price12; } set {  price12 = value; } }
        public decimal Price13 { get {  return price13; } set {  price13 = value; } }
        public decimal Price14 { get {  return price14; } set {  price14 = value; } }
        public decimal Price15 { get {  return price15; } set {  price15 = value; } }
        public decimal Price16 { get {  return price16; } set {  price16 = value; } }
        public decimal Price17 { get {  return price17; } set {  price17 = value; } }
        public decimal Price18 { get {  return price18; } set { price18 = value; } }
        public decimal Price19 { get {  return price19; } set { price19 = value; } }
        public decimal Price20 { get {  return price20; } set {  price20 = value; } }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", name, description, ticker);
        }
    }
}
