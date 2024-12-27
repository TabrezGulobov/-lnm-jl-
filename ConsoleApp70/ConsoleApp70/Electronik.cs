using System;
namespace HomeDevices
{
    public class ElectronicDevice
    {
        private string Brand;
        protected int BatteryLevel;
        private bool IsOn;
        
        public string getBrand
        {
            get { return Brand; }
            set { Brand = value; }
        }
        public int GetBatterylevel
        {
            get { return BatteryLevel; }
            set { BatteryLevel = value; }
        }
        public bool getIsOn
        {
            get { return IsOn; }
            set { IsOn = value; }
        }

        public void TurnOff()
        {
            getIsOn = false;
            Console.WriteLine($"This {Brand} is turned off");
        }

        public void TurnOn()
        {
            getIsOn = true;
            Console.WriteLine($"This {Brand} is turned on");
        }

        public ElectronicDevice(string brand, int batteryLevel)
        {
            Brand = brand;
            GetBatterylevel = batteryLevel;
            IsOn = false;
        }

        public ElectronicDevice()
        {
            getBrand = "Unknown";
            GetBatterylevel = 32;
            getIsOn = true;
        }

        public void AddBatteryLevel(int level)
        {
            BatteryLevel += level;
            if (BatteryLevel > 100)BatteryLevel = 100;
            Console.WriteLine($"This {Brand} is now {BatteryLevel}");   
        }
    }
}