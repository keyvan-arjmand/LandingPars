namespace Landing.Models;

public class LandingDto
{
    public int id { get; set; }
    public string? SeoIndexTitle { get; set; }
    public string? SeoIndexDesc { get; set; }
    public IFormFile Logo { get; set; }
    public string? Number { get; set; }
    public string? SeoIndexCanonical { get; set; }

    
    public string? Sec1Title { get; set; }
    public string? Sec1TitleEn { get; set; }
    public string? Sec1SubTitle { get; set; }
    public string? Sec1SubTitleEn { get; set; }
    public string? Sec1Desc { get; set; }
    public string? Sec1DescEn { get; set; }
    public IFormFile? Sec1Image { get; set; }


    public string? Sec2Title { get; set; }
    public string? Sec2TitleEn { get; set; }
    public string? ServiceTitle1 { get; set; }
    public string? ServiceTitle1En { get; set; }
    public string? ServiceDesc1 { get; set; }
    public string? ServiceDesc1En { get; set; }
    public string? ServiceHref1 { get; set; }
    public string? ServiceImage1 { get; set; }
    public string? ServiceLogo1 { get; set; }

    public string? ServiceTitle2 { get; set; }
    public string? ServiceTitle2En { get; set; }
    public string? ServiceDesc2 { get; set; }
    public string? ServiceDesc2En { get; set; }
    public string? ServiceImage2 { get; set; }
    public string? ServiceHref2 { get; set; }

    public string? ServiceLogo2 { get; set; }

    public string? ServiceTitle3 { get; set; }
    public string? ServiceTitle3En { get; set; }
    public string? ServiceDesc3 { get; set; }
    public string? ServiceDesc3En { get; set; }
    public string? ServiceImage3 { get; set; }
    public string? ServiceHref3 { get; set; }

    public string? ServiceLogo3 { get; set; }
    public string? DescCart { get; set; }
    public string? DescCartEn { get; set; }
}