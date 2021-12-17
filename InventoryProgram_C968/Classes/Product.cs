using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram_C968
{
    public class Product
    {
        public List<Part> AssociatedParts { get; set; }
        public int ProductID { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int InStock { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }

        // If instanced without an ID, assign one from Inventory class
        public Product(string _name, double _price, int _inStock, int _min, int _max, List<Part> _parts_list) : this(Inventory.ProductId, _name, _price, _inStock, _min, _max, _parts_list) { }
        
        // Avoid using this constructor as we want an autoassigned ID.
        public Product(int _productID, string _name, double _price, int _inStock, int _min, int _max, List<Part> _parts_list)
        {
            ProductID = _productID;
            Name = _name;
            Price = _price;
            InStock = _inStock;
            Min = _min;
            Max = _max;
            AssociatedParts = _parts_list;
        }


        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            try
            {
                AssociatedParts.Remove(LookupAssociatedPart(partID));
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public Part LookupAssociatedPart(int partID)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
