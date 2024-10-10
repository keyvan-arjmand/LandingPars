namespace Dal.Entity;

public class Message : BaseEntity
{
    public string Name { get; set; } = string.Empty;
    public string Number { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Desc { get; set; } = string.Empty;
    public DateTime InsertDate { get; set; }
}