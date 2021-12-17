using System;
using System.Collections.Generic;
namespace InventoryProgram_C968
{
    internal class Inventory
    {
        public static List<Product> Products = new List<Product>();
        public static List<Part> AllParts = new List<Part>();

        // Increments when a part or product is added
        public static int next_part_id = 0;
        public static int next_product_id = 0;

        public static int AutoPartId
        {
            get { return next_part_id++; } // Give ID then increment
            set { next_part_id = value; }
        }

        public static int AutoProductId
        {
            get { return next_product_id++; } // Give ID then increment
            set { next_product_id = value; }
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

        public static void UpdateProduct(int productID, Product updated_product)
        {
            Product? oldProduct = null;
            foreach (Product product in Products)
            {
                if (product.ProductID == productID)
                {
                    oldProduct = product;
                }
            }
            if (oldProduct != null)
            {
                var index = Products.IndexOf(oldProduct);
                Products[index] = updated_product;
            }
            oldProduct = updated_product;
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
                if (part.PartID == partID)
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
            }
            oldPart = updated_part;
        }

    }
}
