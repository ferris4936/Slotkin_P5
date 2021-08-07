using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slotkin_P5
{
    class AluminumSprocket : Sprocket
    {
        private string itemMaterial;
        public string ItemMaterial { get; set; }

        const decimal pricePerTeeth = 0.04M;
        public AluminumSprocket() : base()
        {
            ItemMaterial = "Aluminum";
        }

        public AluminumSprocket(int itemId, int numItems, int numTeeth, string itemMaterial)
            : base(itemId, numItems, numTeeth)
        {
            ItemMaterial = itemMaterial;
        }

        protected override void Calc()
        {
            AluminumSprocket alum = new AluminumSprocket();
            alum.Price = NumTeeth * NumItems * pricePerTeeth;
        }

        public override string ToString()
        {
            return base.ToString() + ", Material: " + ItemMaterial;
        }
    }
}
