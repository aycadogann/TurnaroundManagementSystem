using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnaroundManagementSystem
{
    public class Aircraft
    {
        #region 
        private byte _passengerCapacity;
        private int _fuelCapacity;
        private int _currentFuel;

        public Aircraft()
        {

        }
        public Aircraft(string tailNumber, string model)
        {
            TailNumber = tailNumber;
            Model = model;
        }

        public Aircraft(string tailNumber, string model, byte passengerCapacity = 100)
        {
            TailNumber = tailNumber;
            Model = model;
            PassengerCapacity = passengerCapacity;
        }


        public string TailNumber { get; set; }
        public string Model { get; set; }
        public byte PassengerCapacity
        {
            get { return _passengerCapacity; }
            set
            {
                if (value < 0)
                    _passengerCapacity = 0;
                else
                    _passengerCapacity = value;
            }
        }
        public int FuelCapacity
        {
            get
            {
                return _fuelCapacity;
            }
            set
            {
                if (value < 0)
                    _fuelCapacity = 0;
                else
                    _fuelCapacity = value;
            }
        }
        public int CurrentFuel
        {
            get
            {
                return _currentFuel;
            }
            set
            {
                if (value < 0 || value > _fuelCapacity)
                {
                    Console.WriteLine("Lütfen geçerli bir yakıt miktarı giriniz");
                }
                else
                    _currentFuel = value;
            }
        }

        #endregion

        #region behavior
        public void SetFuel()
        {

        }

        public void AddFuel()
        {

        }
        #endregion

    }
}
