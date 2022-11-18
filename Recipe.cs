namespace Famecipe.Models;

public class Recipe
{
    public string? Identifier { get; set; }
    public string? Name { get; set; }
    public string? Image { get; set; }
    public List<string>? Ingredients { get; set; }
    public List<string>? Equipment { get; set; }
    public List<string>? Directions { get; set; }
    public DateTime? WhenUpdatedUTC { get; set; }

}
