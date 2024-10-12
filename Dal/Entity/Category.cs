using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entity;

public class Category : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string TitleEn { get; set; } = string.Empty;
    public string? Href { get; set; }

    public ICollection<SubPage> Pages { get; set; } = default!;
}