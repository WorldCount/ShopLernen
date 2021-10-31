
namespace ShopLernen.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }

        public Car Car { get; set; }

        public double Price { get; set; }

        public string ShopCartId { get; set; }
    }
}
