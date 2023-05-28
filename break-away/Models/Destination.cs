namespace break_away.Models;

public class Destination
{
    public int DestinationId { get; set; }
    public string Name { get; set; }
    public string Country { get; set; }
    public byte[] Photo { get; set; }
    public List<Lodging> Lodgings { get; set; }
}