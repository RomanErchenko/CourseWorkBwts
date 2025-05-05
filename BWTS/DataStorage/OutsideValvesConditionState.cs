using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class OutsideValvesConditionState
    {

        public Guid Id { get; set; }
        // name of outside valve
        public string Name { get; set; } = string.Empty;
        // valve open state
        public bool OpenState { get; set; }
        // valve close state
        public bool CloseState { get; set; }

       



    }
}
