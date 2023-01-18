namespace Realty.Domain.Model;

public class RealtyRentAd
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Description { get; set; }
    public decimal Price { get; set; }

    public LocationDetails Location { get; set; }

    public ContactDetails[] Contacts { get; set; }

}