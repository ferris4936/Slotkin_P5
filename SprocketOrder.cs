using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P5
{
    class SprocketOrder
    {
        private List<Sprocket> sprockets;

        private int itemCount;

        public Address Address { get; set; }

        public string CustomerName { get; set; }

        public decimal TotalPrice { get; set; }

        public List<Sprocket> Sprockets { get { return sprockets; } set { sprockets = value; } }

        public SprocketOrder(string customerName, Address address, List<Sprocket> sprockets, decimal totalPrice)
        {
            this.CustomerName = customerName;
            this.Address = address;
            this.Sprockets = sprockets;
            this.itemCount = Sprockets.Count();
            this.TotalPrice = totalPrice;
            Calc(); 
        }

        public SprocketOrder()
        {
            sprockets = new List<Sprocket>();
            itemCount = 0;
        }

        public void Add(Sprocket sprocket) 
        {
                sprockets.Add(sprocket);  
            
        }

        private void Calc() 
        {
            for(int i = 0; i < sprockets.Count; ++i)
            {
                TotalPrice += sprockets[i].Price;  
            }
        }

        public void Remove(int index) 
        {
            sprockets.RemoveAt(index);

        } 

        public override string ToString()
        {
            return
                "Customer Name: " + CustomerName + "\n" +
                    "Number of Items: " + itemCount + "\n" +
                    "Total Price: $" + TotalPrice + "\n" +
                    "Address: " + Address;      
        }
    }
}
