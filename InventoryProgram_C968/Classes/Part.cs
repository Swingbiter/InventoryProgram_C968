using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram_C968
{
    public abstract class Part
    {
        public int PartID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // If instanced without an ID, assign one from Inventory class
        public Part(string _name, double _price, int _instock, int _min, int _max) :this(Inventory.PartId, _name, _price, _instock, _min, _max) { }
        // Avoid using this constructor as we want an autoassigned ID.
        public Part(int _partID, string _name, double _price, int _instock, int _min, int _max)
        {
            PartID = _partID;
            Name = _name;
            Price = _price;
            InStock = _instock;
            Min = _min; 
            Max = _max;
        }


    }
}
