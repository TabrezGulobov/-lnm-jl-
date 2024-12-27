using System;
namespace HomeDevices
{
    public class PC : ElectronicDevice
    {
        public PC(string brand, int batteryLevel)
        {
            getBrand = brand;
            GetBatterylevel = batteryLevel;
            getIsOn = false;
        }
        public void OpenSettings(string appName)
        {
            if (getIsOn && GetBatterylevel > 0)
            {
                Console.WriteLine($"{getBrand} is opening {appName}...");
                GetBatterylevel -= 10;
                if (GetBatterylevel < 0)
                    GetBatterylevel = 0;
            }
            else
            {
                Console.WriteLine($"Cannot open {appName}. {getBrand} is OFF or has no charge.");
            }
        }
    }
}