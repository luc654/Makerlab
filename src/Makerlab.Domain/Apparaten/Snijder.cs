namespace Makerlab.Domain.Apparaten;

public class Snijder : Apparaat
{
    private Snijder() {}
    
    public Snijder(string naam, string locatie) : base (naam, locatie) {}
    
    public decimal calculateCost(TimeSpan totalTime)
    {
        throw new NotImplementedException();
    }
}