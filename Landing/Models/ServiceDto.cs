namespace Landing.Models;

public class ServiceDto
{
    public int Id { get; set; }
    
    public string? ServiceTitle { get; set; }
    public string? ServiceTitleEn { get; set; }
    
    public string? ServiceDesc { get; set; }
    public string? ServiceDesc1En { get; set; }
    
    public string? ServiceHref { get; set; }
    public string? ServiceImage { get; set; }
    public IFormFile? Image { get; set; }
    public string? ServiceLogo { get; set; }
    public IFormFile? Logo { get; set; }
}