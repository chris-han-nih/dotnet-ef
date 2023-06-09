namespace break_away.Models;

public class Lodging
{
    public int LodgingId { get; set; }
    public string Name { get; set; }
    public string Owner { get; set; }
    public bool IsResort { get; set; }
    public decimal MilesFromNearestAirport { get; set; }
    public int DestinationId { get; set; }
}