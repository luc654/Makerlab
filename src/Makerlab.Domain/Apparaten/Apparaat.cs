namespace Makerlab.Domain.Apparaten;
// https://www.scribd.com/document/940022119/Code-Abstraction the goat
public abstract class Apparaat
{

    public int Id { get; private set; }
    public string Naam { get; private set; } = "";
    public string Locatie { get; private set; } = "";
    public ApparaatStatus Status { get; private set; } = ApparaatStatus.Beschikbaar;

    protected Apparaat() { }   // for EF Core

    protected Apparaat(string naam, string locatie)
    {
        Naam = naam;
        Locatie = locatie;
    }
    
    /// <summary>
    /// CertificateRequired indicates a boolean that the user has a generic certificate needed to operate certain devices.
    /// The conscious desicion was made to make this TRUE by default.
    /// </summary>
    public virtual bool CertificateRequired => true; 
    public void changeStatus(ApparaatStatus newStatus)
    {
        Status = newStatus;
    }
    
}


