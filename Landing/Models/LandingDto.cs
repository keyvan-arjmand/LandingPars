namespace Landing.Models;

public class LandingDto
{
    public int id { get; set; }
    public string? SeoIndexTitle { get; set; }
    public string? SeoIndexDesc { get; set; }
    public string? SeoIndexCanonical { get; set; }
    
    public IFormFile? ImageTopBanner { get; set; }
    public string? ImageTopBannerHref { get; set; }

    public IFormFile? ImageSlider { get; set; }
    public string? TitleSlider { get; set; }
    public string? SubTitleSlider { get; set; }
    public string? TitleSliderEn { get; set; }
    public string? SubTitleSliderEn { get; set; }
    public IFormFile? ImageSlider2 { get; set; }
    public string? TitleSlider2 { get; set; }
    public string? SubTitleSlider2 { get; set; }
    public string? TitleSliderEn2 { get; set; }
    public string? SubTitleSliderEn2 { get; set; }

    public IFormFile? ImageSlider3 { get; set; }
    public string? TitleSlider3 { get; set; }
    public string? SubTitleSlider3 { get; set; }
    public string? TitleSliderEn3 { get; set; }
    public string? SubTitleSliderEn3 { get; set; }

    public IFormFile? ImageSlider4 { get; set; }
    public string? TitleSlider4 { get; set; }
    public string? SubTitleSlider4 { get; set; }
    public string? TitleSliderEn4 { get; set; }
    public string? SubTitleSliderEn4 { get; set; }

    public IFormFile? ImageSlider5 { get; set; }
    public string? TitleSlider5 { get; set; }
    public string? SubTitleSlider5 { get; set; }
    public string? TitleSliderEn5 { get; set; }
    public string? SubTitleSliderEn5 { get; set; }
}