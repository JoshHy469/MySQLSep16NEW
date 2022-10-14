using Google.Protobuf.WellKnownTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySQLSep16.Models
{
    internal class BankModel
    {
        public int tx_type_typeID { get; set; }
        public int txID { get; set; }
        public decimal Amt { get; set; }
        public DateTime txDate { get; set; }
        //public int tx_type_typeID { get; set; }
        public string Type { get; set; }

        public override string ToString()
        {
            string output = $"Transaction Detail\nDate:{txDate}\nType:{Type}\nAmount:{Amt}";

            return output; 
        }


    }
}
