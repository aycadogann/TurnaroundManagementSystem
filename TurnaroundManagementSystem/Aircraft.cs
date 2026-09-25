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
        private int _passengerCapacity;
        private int _fuelCapacity;
        private int _currentFuel;

        public Aircraft()
        {

        }
        public Aircraft(string tailNumber, string model, int fuelCapacity = 250)
        {
            TailNumber = tailNumber;
            Model = model;
            FuelCapacity = fuelCapacity;
        }

        public Aircraft(string tailNumber, string model, int fuelCapacity = 250, int passengerCapacity = 100)
        {
            TailNumber = tailNumber;
            Model = model;
            FuelCapacity = fuelCapacity;
            PassengerCapacity = passengerCapacity;
        }


        public string TailNumber { get; set; }
        public string Model { get; set; }
        public int PassengerCapacity
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
                {
                    _fuelCapacity = 0;
                    Console.WriteLine("Yakıt kapasitesi negatif olamaz!!");
                }
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
                if (value < 0)
                {
                    Console.WriteLine("Lütfen geçerli bir yakıt miktarı giriniz");
                    _currentFuel = 0;
                }
                else if (value > FuelCapacity)
                {
                    _currentFuel = FuelCapacity;
                }
                else
                    _currentFuel = value;
            }
        }

        #endregion

        #region behavior
        public void SetFuel(int fuelAmount)
        {
            if (fuelAmount <0)
            {
                Console.WriteLine("Yakıt miktarı negatif olamaz!");  
            } else if(fuelAmount > FuelCapacity)
            {
                Console.WriteLine("Girilen yakıt depo kapasitesini aşıyor.");
            }
            else
            {
                CurrentFuel = fuelAmount;
                Console.WriteLine("Yakıt güncellendi");
            }
        }

        public void AddFuel(int fuel)
        {
            if ((CurrentFuel+fuel) <= FuelCapacity)
            {
                CurrentFuel += fuel;
                Console.WriteLine("Yakıt ekleme işlemi tamamlandı");
            }
            else
            {
                Console.WriteLine("Eklemek istediğiniz miktar depo kapasitesini aşmaktadır.");
            }
        }
        #endregion

    }
}
