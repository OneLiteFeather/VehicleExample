namespace VehicleExample;

public abstract class Car
{
    protected int Doors; // only set once in constructor
    private string Color; // Get and set
    private int Horsepower; // Get and set
    
    protected Car(int doors, string color, int horsepower)
    {
        Doors = doors;
        Color = color;
        Horsepower = horsepower;
    }
    
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

    public virtual string GetInfo()
    {
        return ($"Car Info: {Doors} doors, {Color} color, {Horsepower} horsepower");
    }
    
}