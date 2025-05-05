using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    //BWTS working valves inside system
    public class BwtsInsideOperatingValves
    {
        //valve Id
     public Guid Id { get; set; }
     // name of the valve
     public string Name { get; set; }=string.Empty;
     // open indication
     public bool OpenState { get; set; }
     // close indication
     public bool CloseState { get; set; }
       // open order 
     public bool OpenOrder { get; set; }
     //close order
     public bool CloseOrder { get; set; }
     // valve condition
      public bool Condition { get; set; }
     

    }
}
