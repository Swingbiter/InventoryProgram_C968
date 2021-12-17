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

        // Add ability to retrieve inherited
        public virtual string get_company_name() { return ""; }
        public virtual int get_machine_id() { return 0; }

        // If instanced without an ID, assign one from Inventory class
        public Part(string _name, double _price, int _instock, int _min, int _max) :this(Inventory.AutoPartId, _name, _price, _instock, _min, _max) { }
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
