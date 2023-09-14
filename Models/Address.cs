using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class Address : CdccBaseEntity
{
    public User User { get; set; }
    public string Street { get; set; }
    [Required]
    public string City { get; set; }
    public string StateCode { get; set; }
    [RegularExpression(@"^\d{5}$")]
    public string PostalCode { get; set; }
    public string CountryCode { get; set; }
}
