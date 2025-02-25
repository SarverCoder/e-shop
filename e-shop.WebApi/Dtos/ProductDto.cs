namespace e_shop.WebApi.Dtos;

public class ProductDto
{
    public int Id { get; set; }


    public string? ProductName { get; set; }


    public string? SKU { get; set; }


    public decimal RegularPrice { get; set; }

    public decimal DiscountPrice { get; set; }

    public int Quantity { get; set; }
    public decimal ProductWeight { get; set; }
    public bool Published { get; set; }

}
