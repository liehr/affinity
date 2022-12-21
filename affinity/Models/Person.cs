namespace affinity.Models;

public class Person
{
    public Guid Id { get; set; }
    
    public string Name { get; set; } = string.Empty;

    public List<Social>? Socials { get; set; }
}