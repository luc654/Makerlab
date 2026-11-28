namespace Makerlab.Domain.Apparaten;

public class Printer : Apparaat
{
    private Filamenttype filament;
    public override bool CertificateRequired => false;    
    
    // Takes the amount of grams, returns a price. For simplisity sake round grams upwards
    // 
    public decimal calculateCost(TimeOnly totalTime, int grams)
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