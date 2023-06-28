using System.Globalization;
using iDelivery.Entities;
using iDelivery.Entities.Enums;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
String clientName = Console.ReadLine(); // Alex Green
Console.Write("Email: ");
String email = Console.ReadLine(); // alex@gmail.com
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine()); // 15/03/1985

Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine()); // Processing

Client client = new(clientName, email, birthDate);
Order order = new(DateTime.Now, status, client);

Console.Write("How many items to this order? ");
int amountItems = int.Parse(Console.ReadLine()); // 2

for (int i = 1; i <= amountItems; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine(); // TV / Mouse
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); // 1000.00 / 40.00
    Product product = new Product(productName, price);

    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine()); // 1 / 2
    OrderItem orderItem = new OrderItem(product, price, quantity);

    order.AddItem(orderItem);
}


Console.WriteLine();
Console.WriteLine(order);
