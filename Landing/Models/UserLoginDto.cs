﻿namespace Landing.Models;

public class UserLoginDto
{
    public long Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Family { get; set; } = string.Empty;
    public string Image { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
}