namespace break_away.Models;

using System.ComponentModel.DataAnnotations;

public class Destination
{
    public int DestinationId { get; set; }
    [Required]
    public string Name { get; set; }
    public string Country { get; set; }
    [MaxLength(500)]
    public string Description { get; set; }
    public string Photo { get; set; }
    public List<Lodging> Lodgings { get; set; }
}