using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class Gps
    {
        public Guid Id { get; set; }
        // Longitude of Gps signal
        public string Longitude { get; set; } = string.Empty;
        // Latitude of Gps signal
        public string Latitude { get; set; } = string.Empty;
        // Datetime of Gps Signal
        public DateTime DateTime { get; set; }  


    }
}
