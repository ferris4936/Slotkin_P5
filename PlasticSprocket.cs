using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P5
{
    class PlasticSprocket : Sprocket
    {
        //private string itemMaterial;  
        public string ItemMaterial { get; set; }

        const decimal pricePerTeeth = 0.02M;
        public PlasticSprocket() : base()
        {
            ItemMaterial = "Plastic";
        }

        public PlasticSprocket(int itemId, int numItems, int numTeeth, string itemMaterial)
            : base(itemId, numItems, numTeeth)
        {
            ItemMaterial = itemMaterial;
        }

        protected override void Calc()
        {
            PlasticSprocket plastic = new PlasticSprocket();
            plastic.Price = NumTeeth * NumItems * pricePerTeeth;
        }

        public override string ToString()

        {
            return base.ToString() + ", Material: " + ItemMaterial;
        }
    }
}
