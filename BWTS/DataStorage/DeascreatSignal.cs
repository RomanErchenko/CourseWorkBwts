using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class DeascreatSignal
    {
        // id of input signal
        public Guid Id { get; set; }
        // name of input signal
        public string Name { get; set; }=string.Empty;
        // condition of input signal
        public bool IsActive { get; set; }

    }
}
