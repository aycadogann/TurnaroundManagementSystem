using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Flight
    {
        #region 
        private int _passengerCount;
        public string FlightNumber { get; set; }
        public string Destination { get; set; }
        public DateTime ArrivalTime { get; set; }
        public DateTime DepartureTime { get; set; }
        public int PassengerCount
        {
            get
            { return _passengerCount; }
            set
            {
                if (value < 0)
                    _passengerCount = 0;
                else
                {
                    _passengerCount = value;
                }
            }
        }
        public Aircraft Aircraft { get; set; }
        public Gate Gate { get; set; }

        #endregion

        #region behaviour
        public bool CanCarryPassengers(int passengerCount, int aircraftPassengerCount)
        {
            if (passengerCount > aircraftPassengerCount)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        #endregion
    }
}
