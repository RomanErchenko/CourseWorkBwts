using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class BwtsInsightTrottleValve
    {
        //valve Id
        public Guid Id { get; set; }
        // name of the valve
        public string Name { get; set; } = string.Empty;
        // valve indication
        public decimal Indication { get; set; }
        public bool OpenOrder { get; set; }
        //close order
        public bool CloseOrder { get; set; }
        // valve condition
        public bool Condition { get; set; }



    }
}
