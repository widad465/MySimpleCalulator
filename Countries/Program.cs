public class Country
{
    public string CountryCode { get; set; } = default!;
    public int CountryExtension { get; set; } 
    public string CountryName { get; set; } = default!;

    public Country(string countryCode, int countryExtension, string countryName)    
    {
        CountryCode = countryCode;
        CountryExtension = countryExtension;
        CountryName = countryName;
    }
}



