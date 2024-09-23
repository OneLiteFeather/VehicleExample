namespace VehicleExample.net.onelitefeather.carObjects;

public abstract class Car(int doors, string color, int horsepower, double kilometer, double fuel)
{
    protected int Doors = doors; // only set once in constructor
    private string Color = color; // Get and set
    private int Horsepower = horsepower; // Get and set
    private double Kilometer = kilometer;
    private double Fuel = fuel;

    public int GetDoorsAmount()
    {
        return Doors;
    }

    public string GetColor()
    {
        return Color;
    }

    public void SetColor(string color)
    {
        Color = color;
    }

    public int GetHorsepower()
    {
        return Horsepower;
    }

    public void SetHorsepower(int horsepower)
    {
        Horsepower = horsepower;
    }

    public void SetKilometer(double kilometer)
    {
        Kilometer = kilometer;
    }

    public double GetKilometer()
    {
        return Kilometer;
    }

    public double GetFuel()
    {
        return Fuel;
    }
    public void SetFuel(double fuel)
    {
        Fuel = fuel;
    }

    public virtual string GetInfo()
    {
        return $"Car Info: {Doors} doors, {Color} color, {Horsepower} horsepower";
    }

    public double GetFuelConsumption()
    {
        var fuelConsumption = (GetFuel() / 100.0) * GetKilometer();
        return fuelConsumption; // k
    }

    public string PrintGetFuelConsumption()
    {
        return $"Fuel consumption: {GetFuelConsumption()}";
    }
    
}