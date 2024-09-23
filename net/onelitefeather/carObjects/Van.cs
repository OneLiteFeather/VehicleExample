namespace VehicleExample.net.onelitefeather.carObjects;

public class Van : Kombi
{
    private readonly bool loadingArea;
    
    public Van(string color, int ps, bool hasLoadingArea, double kilometer) : base(color, ps, kilometer)
    {
        loadingArea = hasLoadingArea;
        if (loadingArea)
        {
            Doors = 2;
            SetFuel(12);
        }
        else
        {
            SetFuel(10);
        }
        
    }

    public override string GetInfo()
    {
        return ($"Car info: {Doors} doors, {GetColor()} color, {GetHorsepower()} horsepower, has loading area: {loadingArea}");
    }
    
}