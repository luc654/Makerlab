namespace Makerlab.Domain.Apparaten;

public class VRSet : Apparaat
{
    
    private VRSet() {}
    public VRSet(string naam, string locatie) : base (naam, locatie) {}

    public decimal calculateCost()
    {
        throw new NotImplementedException();
    }
}