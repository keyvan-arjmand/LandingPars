namespace Dal.Entity;

public class LandingPage : BaseEntity
{
    public string? SeoIndexTitle { get; set; }
    public string? SeoIndexDesc { get; set; }
    public string? Logo { get; set; }
    public string? Number { get; set; }
    public string? SeoIndexCanonical { get; set; }
    public string? Sec1Title { get; set; }
    public string? Sec1SubTitle { get; set; }
    public string? Sec1Desc { get; set; }
    public string? Sec1Image { get; set; }


    public string? Sec2Title { get; set; }
    public string? ServiceTitle1 { get; set; }
    public string? ServiceDesc1 { get; set; }
    public string? ServiceHref1 { get; set; }
    public string? ServiceImage1 { get; set; }
    public string? ServiceLogo1 { get; set; }

    public string? ServiceTitle2 { get; set; }
    public string? ServiceDesc2 { get; set; }
    public string? ServiceImage2 { get; set; }
    public string? ServiceHref2 { get; set; }

    public string? ServiceLogo2 { get; set; }

    public string? ServiceTitle3 { get; set; }
    public string? ServiceDesc3 { get; set; }
    public string? ServiceImage3 { get; set; }
    public string? ServiceHref3 { get; set; }

    public string? ServiceLogo3 { get; set; }
    public string? DescCart { get; set; }
}