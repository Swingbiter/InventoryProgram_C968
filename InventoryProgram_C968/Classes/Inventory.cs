using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram_C968
{
    internal class Inventory
    {
        public static List<Product> Products = new List<Product>();
        public static List<Part> AllParts = new List<Part>();

        // Increments when a part or product is added
        private static int part_id = 0;
        private static int product_id = 0;

        public static int PartId
        {
            get { return part_id++; } // Give ID then increment
            set { part_id = value; }
        }

        public static int ProductId
        {
            get { return product_id++; } // Give ID then increment
            set { product_id = value; }
        }

        // Product Methods
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }

        public static bool removeProduct(int productID)
        {
            try
            {
                Products.Remove(lookupProduct(productID));
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static Product lookupProduct(int productID)
        {
            foreach (Product product in Products)
                if (product.ProductID == productID)
                {
                    return product;
                }
            return null;
        }

        // Part methods
        public static void addPart(Part part)
        {
            AllParts.Add(part);
        }

        public static void removePart(Part part)
        {
            AllParts.Remove(part);
        }

        public static Part lookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.PartID == part_id)
                {
                    return part;
                }
            }
            return null;
        }

        public static void UpdatePart(int partID, Part updated_part)
        {
            Part? oldPart = null;
            foreach (Part part in AllParts)
            {
                if (part.PartID == partID)
                {
                    oldPart = part;
                }
            }
            if (oldPart != null)
            {
                var index = AllParts.IndexOf(oldPart);
                AllParts[index] = updated_part;
                oldPart = updated_part;
            }
        }

    }
}
