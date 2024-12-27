using System;
namespace HomeDevices
{
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicDevice e1 = new ElectronicDevice();
            Telephone telephone = new Telephone();
            Console.WriteLine(telephone.getBrand);
            Console.WriteLine(telephone.getIsOn);
            Console.WriteLine(telephone.GetBatterylevel);
            telephone.AddBatteryLevel(20);
            Console.WriteLine(e1.getBrand);
            Console.WriteLine(e1.getIsOn);
            Console.WriteLine(e1.GetBatterylevel);
            e1.AddBatteryLevel(43);
        }
    }
}