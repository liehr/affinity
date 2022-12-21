using affinity.Models;
using Microsoft.AspNetCore.Mvc;

namespace affinity.Controllers;

[ApiController]
[Route("[controller]")]
public class CollabController : ControllerBase
{
    private static List<Collab> _collabs = new()
    {
        new Collab { Id = Guid.NewGuid(), Name = "Testcollab", Created = DateTime.UtcNow, Password = "test" }
    };
    
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_collabs);
    }
    
    [HttpGet("{id}")]
    public IActionResult Get(Guid id)
    {
        var collab = _collabs.FirstOrDefault(x => x.Id == id);
        if (collab == null)
            return NotFound();
        return Ok(collab);
    }
    
    [HttpPost]
    public IActionResult Post([FromBody] Collab collab)
    {
        _collabs.Add(collab);
        return Ok(collab);
    }
    
    [HttpPut("{id}")]
    public IActionResult Put(Guid id, [FromBody] Collab collab)
    {
        var index = _collabs.FindIndex(x => x.Id == id);
        if (index == -1)
            return NotFound();
        _collabs[index] = collab;
        return Ok(collab);
    }
    
    [HttpDelete("{id}")]
    public IActionResult Delete(Guid id)
    {
        var index = _collabs.FindIndex(x => x.Id == id);
        if (index == -1)
            return NotFound();
        _collabs.RemoveAt(index);
        return NoContent();
    }
}