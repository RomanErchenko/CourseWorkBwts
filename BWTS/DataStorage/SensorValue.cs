using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class SensorValue
    {
        // id of the sensor
        public Guid Id { get; set; }
        // name of the sensor
        public string Name { get; set; }=string.Empty;
        // value of the sensor
        public decimal Value { get; set; }
        // condition of the sensor
        public bool Condition { get; set; }
    }
}
