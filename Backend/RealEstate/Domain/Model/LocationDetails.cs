namespace Realty.Domain.Model;

public class LocationDetails
{
    public long Id { get; set; }
    public string RawAddress { get; set; }
    public string Country { get; set; }
    public string Region { get; set; }
    public string City { get; set; }
    public string Street { get; set; }
    public string PostalCode { get; set; }
    public int? Latitude { get; set; }
    public int? Longitude { get; set; }
}
