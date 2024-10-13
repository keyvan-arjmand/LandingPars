namespace Dal.Entity;

public class OurService : BaseEntity
{
    public string? SecTitle { get; set; }
    public string? SecTitleEn { get; set; }
    public string? SecSubTitle { get; set; }
    public string? SecSubTitleEn { get; set; }
    public string? SecDesc { get; set; }
    public string? SecDescEn { get; set; }
    public string? ServiceLogo{ get; set; }
    public string? ServiceHref { get; set; }

}