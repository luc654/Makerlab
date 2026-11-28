namespace Makerlab.Domain.Apparaten;
// https://www.scribd.com/document/940022119/Code-Abstraction the goat
public abstract class Apparaat
{
    private int id;
    private string naam;
    private string locatie; // need to find something smarter for this.
    private ApparaatStatus _apparaatStatus;
    
    /// <summary>
    /// CertificateRequired indicates a boolean that the user has a generic certificate needed to operate certain devices.
    /// The conscious desicion was made to make this TRUE by default.
    /// </summary>
    public virtual bool CertificateRequired => true; 
    public void changeStatus(ApparaatStatus newStatus)
    {
        _apparaatStatus = newStatus;
    }
    
}


