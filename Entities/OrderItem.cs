using System.Globalization;

namespace iDelivery.Entities
{
    internal class OrderItem
    {
        Product Product { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public OrderItem() { }
        public OrderItem(Product product, double price, int quantity)
        {
            Price = price;
            Quantity = quantity;
            Product = product;
        }

        public double SubTotal() {
            return Quantity * Price;
        }

        public override string ToString()
        {
            return Product.Name
                + ", $"
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", Quantity: "
                + Quantity
                + ", Subtotal: $"
                + SubTotal().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
