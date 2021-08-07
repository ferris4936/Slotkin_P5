using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P5
{
    class SteelSprocket : Sprocket 
    {
        private string itemMaterial;
        public string ItemMaterial { get; set; }

        const decimal pricePerTeeth = 0.05M;   
        public SteelSprocket(): base() 
        {
            ItemMaterial = "Steel";
        } 
        
        public SteelSprocket(int itemId, int numItems, int numTeeth, string itemMaterial)
            : base(itemId, numItems, numTeeth)
        {
            ItemMaterial = itemMaterial; 
        }

        protected override void Calc()
        {
            SteelSprocket steel = new SteelSprocket();
            steel.Price = NumTeeth * NumItems * pricePerTeeth;  //ahhh, how else do you get the value into Price if its a readonly        
        }

        public override string ToString()
        {
            return base.ToString() + ", Material: " + ItemMaterial;  
        }

    }
}
