using Microsoft.EntityFrameworkCore;

// Models/Sale.cs
public class Sale
{
    public int id { get; set; }
    public DateTime orderdate { get; set; }
    public string region { get; set; }
    public string rep { get; set; }
    public string item { get; set; }
    public int units { get; set; }
    public decimal unitcost { get; set; }
    public decimal total { get; set; }
}
