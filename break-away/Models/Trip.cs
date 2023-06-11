namespace break_away.Models;

public class Trip
{
    public Guid Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public decimal CostUSD { get; set; }
    public byte[] RowVersion { get; set; }
}