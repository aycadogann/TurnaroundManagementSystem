using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Gate
    {
        private bool _isOccupied;

        public string GateCode { get; set; }
        public bool IsOccupied
        {
            get
            {
                return _isOccupied;
            }
            set
            {
                if (value == true)
                    return;
                else
                    _isOccupied = value;
            }
        }
        public int CurrentFlight { get; set; }

    }
}
