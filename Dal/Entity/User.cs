using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace Dal.Entity;

public class User: IdentityUser<int>
{
    public string Name { get; set; } = string.Empty;
    public string Family { get; set; } = string.Empty;
    public string ImageName { get; set; } = string.Empty;
    public string ConfirmCode { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
    public DateTime InsertDate { get; set; } = DateTime.Now;
    public DateTime ConfirmCodeExpireTime { get; set; }
}