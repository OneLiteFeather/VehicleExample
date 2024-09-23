using VehicleExample.net.onelitefeather.carObjects;

namespace VehicleExample.net.onelitefeather
{
    class VehicleMain
    {
        private readonly static CompactCar _compactCar = new("green", 150, 35);
        private readonly static Kombi _kombi = new("orange", 50, 25);
        private readonly static Van _van = new("blue", 101,false, 115);
        private readonly static Van _vanWithLoadingArea = new("blue", 101,true,100);

        public static void Main(string[] args)
        {
            Console.WriteLine(_compactCar.GetInfo());
            Console.WriteLine(_compactCar.PrintGetFuelConsumption());
            Console.WriteLine(_kombi.GetInfo());
            Console.WriteLine(_kombi.PrintGetFuelConsumption());
            Console.WriteLine(_van.GetInfo());
            Console.WriteLine(_van.PrintGetFuelConsumption());
            Console.WriteLine(_vanWithLoadingArea.GetInfo());
            Console.WriteLine(_vanWithLoadingArea.PrintGetFuelConsumption());
        }
    }
}

