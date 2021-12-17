using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
