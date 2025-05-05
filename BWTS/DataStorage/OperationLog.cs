using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    public class OperationLog
    {
        public Guid Id { get; set; }
        // Name of operation
        public string NameOfOperation { get; set; } = string.Empty;
        // Date of Operation
        public DateTime Date { get; set; }
      



    }
}
