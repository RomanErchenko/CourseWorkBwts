using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class DigitalOutput
    {
        // Digit Id
        public Guid Id { get; set; }
        // name of digit output
        public string Name { get; set; }=string.Empty;
        //digit output condition
        public bool DigitOutput { get; set; }


    }
}
