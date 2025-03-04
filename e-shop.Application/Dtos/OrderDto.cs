namespace e_shop.Application.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderApprovedAt { get; set; }
        public DateTime OrderDeliveredCarrierDate { get; set; }
        public DateTime OrderDeliveredCustomerDate { get; set; }
    }
}
