using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class GroundOperation
    {
        public GroundOperation()
        {

        }
        public GroundOperation(string _operationName)
        {
            OperationName = _operationName;
        }
        public GroundOperation(string _operationName, byte _estimatedMinutes)
        {
            OperationName = _operationName;
            EstimatedMinutes = _estimatedMinutes;
        }

        public string OperationName { get; set; }
        public byte EstimatedMinutes { get; set; }
        public bool IsCompleted { get; set; }
        public string ResponsibleEmployee { get; set; }


    }
}
