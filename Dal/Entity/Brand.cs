namespace Dal.Entity;

public class Brand:BaseEntity
{
    public string Logo { get; set; } = string.Empty;
    public string? Title { get; set; }
}