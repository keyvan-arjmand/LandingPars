using System.ComponentModel.DataAnnotations.Schema;

namespace Dal.Entity;

public class SubPage : BaseEntity
{
    public string Title { get; set; } = string.Empty;
    public string TitleEn { get; set; } = string.Empty;
    public string? Desc { get; set; }
    public string? DescEn { get; set; }
    public string? SeoTitle { get; set; }
    public string? SeoDesc { get; set; }
    public string? SeoTitleEn { get; set; }
    public string? SeoDescEn { get; set; }
    public string? SeoCanonical { get; set; }
    public string? Href { get; set; }
    public string? HrefEn { get; set; }
    public int CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))] public Category Category { get; set; } = default!;
}