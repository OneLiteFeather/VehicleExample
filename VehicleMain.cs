using VehicleExample.net.onelitefeather.carObjects;

namespace VehicleExample
{
    class VehicleMain
    {
        static CompactCar _compactCar = new("green", 150);
        static Kombi _kombi = new("orange", 50);
        static Van _van = new("blue", 101,false);
        static Van _vanWithLoadingArea = new("blue", 101,true);

        public static void Main(string[] args)
        {
            Console.WriteLine(_compactCar.GetInfo());
            Console.WriteLine(_kombi.GetInfo());
            Console.WriteLine(_van.GetInfo());
            Console.WriteLine(_vanWithLoadingArea.GetInfo());
        }
    }
}

