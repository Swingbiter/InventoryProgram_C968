namespace InventoryProgram_C968
{
    public class Outsourced : Part
    {
        public string CompanyName { get; set; }

        public Outsourced(string _name, double _price, int _instock, int _min, int _max, string _companyName) : base(_name, _price, _instock, _min, _max)
        {
            CompanyName = _companyName;
        }

        public Outsourced(int _partID, string _name, double _price, int _instock, int _min, int _max, string _companyName) : base(_partID, _name, _price, _instock, _min, _max)
        {
            CompanyName = _companyName;
        }

        public override string get_company_name()
        {
            return CompanyName;
        }
    }
}
