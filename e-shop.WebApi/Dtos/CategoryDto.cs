﻿namespace e_shop.WebApi.Dtos;

public class CategoryDto
{
    public int Id { get; set; }
    public string? CategoryName { get; set; }
    public string? CategoryDescription { get; set; }
    public string? Icon { get; set; }
}
