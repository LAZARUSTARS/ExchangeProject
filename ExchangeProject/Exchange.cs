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
        private string currentCap;
        private int ebitda;
        private int price1;
        private int price2;
        private int price3;
        private int price4;
        private int price5;
        private int price6;
        private int price7;
        private int price8;
        private int price9;
        private int price10;
        private int price11;
        private int price12;
        private int price13;
        private int price14;
        private int price15;
        private int price16;
        private int price17;
        private int price18;
        private int price19;
        private int price20;

        public Exchange(int idStock, string name, string description, string ticker, string currentCap, int ebitda, int price1, int price2, int price3, int price4, int price5, int price6, int price7, int price8, int price9, int price10, int price11, int price12, int price13, int price14, int price15, int price16, int price17, int price18, int price19, int price20)
        {
            this.idStock = idStock;
            this.name = name;
            this.description = description;
            this.ticker = ticker;
            this.currentCap = currentCap;
            this.ebitda = ebitda;
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
        public string Ticker { get {  return ticker; } set {  ticker = value; } }
        public int Price1 { get {  return price1; } set {  price1 = value; } }
        public int Price2 { get {  return price2; } set {  price2 = value; } }
        public int Price3 { get {  return price3; } set {  price3 = value; } }
        public int Price4 { get {  return price4; } set {  price4 = value; } }
        public int Price5 { get {  return price5; } set {  price5 = value; } }
        public int Price6 { get {  return price6; } set {  price6 = value; } }
        public int Price7 { get {  return price7; } set {  price7 = value; } }
        public int Price8 { get {  return price8; } set {  price8 = value; } }
        public int Price9 { get {  return price9; } set {  price9 = value; } }
        public int Price10 { get {  return price10; } set {  price10 = value; } }
        public int Price11 { get {  return price11; } set {  price11 = value; } }
        public int Price12 { get {  return price12; } set {  price12 = value; } }
        public int Price13 { get {  return price13; } set {  price13 = value; } }
        public int Price14 { get {  return price14; } set {  price14 = value; } }
        public int Price15 { get {  return price15; } set {  price15 = value; } }
        public int Price16 { get {  return price16; } set {  price16 = value; } }
        public int Price17 { get {  return price17; } set {  price17 = value; } }
        public int Price18 { get {  return price18; } set { price18 = value; } }
        public int Price19 { get {  return price19; } set { price19 = value; } }
        public int Price20 { get {  return price20; } set {  price20 = value; } }

        public override string ToString()
        {
            return String.Format("{0} {1} {2}", name, description, ticker);
        }
    }
}
