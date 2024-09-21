namespace VehicleExample;

public class Van : Kombi
{
    private bool loadingArea;
    
    public Van(string color, int ps, bool hasLoadingArea) : base(color, ps)
    {
        loadingArea = hasLoadingArea;
        if (loadingArea)
        {
            Doors = 2;
        }
    }

    public override string GetInfo()
    {
        return ($"Car info: {Doors} doors, {GetColor()} color, {GetHorsepower()} horsepower, has loading area: {loadingArea}");
    }
    
}