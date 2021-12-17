using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryProgram_C968
{
    public class Inhouse : Part
    {
        public int machineID { get; set; }

        public Inhouse(string _name, double _price, int _instock, int _min, int _max, int _machineID) : base(_name, _price, _instock, _min, _max)
        {
            machineID = _machineID;
        }

        public Inhouse(int _partID, string _name, double _price, int _instock, int _min, int _max, int _machineID) : base(_partID, _name, _price, _instock, _min, _max)
        {
            machineID = _machineID;
        }

        public override int get_machine_id()
        {
            return machineID;
        }
    }
}
