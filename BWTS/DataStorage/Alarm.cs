using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    //Alarm for BWTS
    public class Alarm
    {
       // Id of the alarm
       public Guid Id { get; set; }
        //Name of the alarm
       public string Name { get; set; }=string.Empty;
        //DateTime of the alarm
       public DateTime Date { get; set; }  
        // Status of the alarm
       public bool IsActive { get; set; }



    }
}
