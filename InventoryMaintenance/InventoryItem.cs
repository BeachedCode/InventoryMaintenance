using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class InventoryItem
    {
        //Ethan Beach
        public InventoryItem() //Constructor for Inventory Item, used for calling method
        {

        }
        public string ItemNo { get; set; } = "";
        public string Description { get; set; } = "";

        public decimal Price { get; set; }

        public string GetDisplayText(string sep)
        {
            return $"{ItemNo} {sep} {Description} {sep} {Price.ToString("c")}";
        }
    }

}
