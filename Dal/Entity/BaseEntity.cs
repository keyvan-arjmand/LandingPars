using System.ComponentModel.DataAnnotations;

namespace Dal.Entity;

public class BaseEntity
{
    [Key] public int Id { get; set; }
    public bool IsDelete { get; set; }= false;
}