namespace affinity.Models;

public class Collab
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;
    
    public DateTime Created { get; set; }
    
    public DateTime Updated { get; set; }

    public string Password { get; set; } = string.Empty;
    
    public List<Person>? Persons { get; set; }
}