namespace break_away.Controllers;

using break_away.Data;
using break_away.Models;
using Microsoft.AspNetCore.Mvc;

[Route("/api/[controller]")]
public class BreakAwayController: ControllerBase
{
    private readonly BreakAwayContext _context;
    public BreakAwayController(BreakAwayContext context)
    {
        _context = context;
    }
    
    [HttpGet("destinations")]
    public IActionResult GetDestinations()
    {
        var destinations = _context.Destinations.ToList();
        return Ok(destinations);
    }
    
    [HttpGet("destinations/{id}")]
    public IActionResult GetDestination(int id)
    {
        var destination = _context.Destinations.Find(id);
        return Ok(destination);
    }
    
    [HttpPost("destinations")]
    public IActionResult CreateDestination([FromBody] Destination destination)
    {
        _context.Destinations.Add(destination);
        _context.SaveChanges();
        return Ok(destination);
    }
    
    [HttpPost("trips")]
    public IActionResult CreateTrip([FromBody] Trip trip)
    {
        _context.Trips.Add(trip);
        _context.SaveChanges();
        return Ok(trip);
    }

    [HttpPost("people")]
    public IActionResult CreatePerson([FromBody] Person person)
    {
        _context.Persons.Add(person);
        _context.SaveChanges();
        return Ok(person);
    }
}