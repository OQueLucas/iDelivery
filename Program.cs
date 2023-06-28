using System.Globalization;
using iDelivery.Entities;
using iDelivery.Entities.Enums;

Console.WriteLine("Enter client data: ");
Console.Write("Name: ");
string clientName = Console.ReadLine();
Console.Write("Email: ");
string email = Console.ReadLine();
Console.Write("Birth date (DD/MM/YYYY): ");
DateTime birthDate = DateTime.Parse(Console.ReadLine());
Console.WriteLine("Enter order data: ");
Console.Write("Status: ");
OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
Client client = new(clientName, email, birthDate);
Order order = new(DateTime.Now, status, client);
Console.Write("How many items to this order? ");
int amountItems = int.Parse(Console.ReadLine());

for (int i = 1; i <= amountItems; i++)
{
    Console.WriteLine($"Enter #{i} item data:");
    Console.Write("Product name: ");
    string productName = Console.ReadLine();
    Console.Write("Product price: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Product product = new(productName, price);
    Console.Write("Quantity: ");
    int quantity = int.Parse(Console.ReadLine());
    OrderItem orderItem = new(product, price, quantity);
    order.AddItem(orderItem);
}
Console.WriteLine();
Console.WriteLine(order);