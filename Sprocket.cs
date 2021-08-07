using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P5
{
    abstract class Sprocket
    {
        private int numItems;   
        private int numTeeth;
        private decimal pricePerTeeth;
        private readonly decimal price;  
        private readonly int itemId;

        public int NumItems { get; set; }
        public int NumTeeth { get; set; }

        public decimal PricePerTeeth { get; set; }

        public decimal Price { get { return price; } }

        public int ItemId { get { return itemId; } } 

        public Sprocket(int itemId, int numItems, int numTeeth)
        {
            this.itemId = itemId;
            this.NumItems = numItems;
            this.NumTeeth = numTeeth;
            this.price = NumTeeth * NumItems * PricePerTeeth;  //I'm just trying to get a value into Price...fail
        }  

        public Sprocket() : this (0, 0, 0) { } 

        protected abstract void Calc();

        public override string ToString()
        {
            return
                "Order num: " + ItemId + ", Number of Items: " + NumItems +
                    ", Teeth: " + NumTeeth + ", Price: $" + Price; 
        }
    }
}
