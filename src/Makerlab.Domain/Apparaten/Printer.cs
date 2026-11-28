namespace Makerlab.Domain.Apparaten;

public class Printer : Apparaat
{
    
    private Printer() {}
    
    public Printer(string naam, string locatie) : base(naam, locatie) {}
    private Filamenttype filament;
    public override bool CertificateRequired => false;    
    
    // Takes the amount of grams, returns a price. For simplisity sake round grams upwards
    // 
    public decimal calculateCost(TimeSpan totalTime, int grams)
    {
        throw new NotImplementedException();
    }
}

// See 'kosten'
enum Filamenttype
{
    PLA,
    PETG
}