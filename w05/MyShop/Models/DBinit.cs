using Microsoft.EntityFrameworkCore;

namespace MyShop.Models;

public class DBinit
{
    public static void Seed(IApplicationBuilder app)
    {
        using var serviceScope = app.ApplicationServices.CreateScope();
        ItemDbContext context = serviceScope.ServiceProvider.GetRequiredService<ItemDbContext>();
        context.Database.EnsureDeleted();
        context.Database.EnsureCreated();

        if (!context.Items.Any())
        {
            var items = new List<Item>
            {
                new Item
                {
                    Name = "Vegan Pizza",
                    Price = 150,
                    Description = "Delicious pizza with soy pepperoni and vegan cheese.",
                    ImageUrl = "/images/pizza.jpg"
                },
                new Item
                {
                    Name = "Coke",
                    Price = 30,
                    Description = "Popular carbonated soft drink.",
                    ImageUrl = "/images/coke.jpg"
                },
                new Item
                {
                    Name = "Vegan Chicken Leg",
                    Price = 120,
                    Description = "Crispy plant-based 'chicken' leg with herbs and smoky seasoning.",
                    ImageUrl = "/images/chickenleg.jpg"
                },
                new Item
                {
                    Name = "French Fries",
                    Price = 60,
                    Description = "Crispy golden fries made with sunflower oil and sea salt.",
                    ImageUrl = "/images/frenchfries.jpg"
                },
                new Item
                {
                    Name = "Vegan Ribs",
                    Price = 220,
                    Description = "Tender seitan ribs glazed with a rich smoky BBQ sauce.",
                    ImageUrl = "/images/ribs.jpg"
                },
                new Item
                {
                    Name = "Cider",
                    Price = 45,
                    Description = "Refreshing apple cider made from 100% natural ingredients.",
                    ImageUrl = "/images/cider.jpg"
                },
                new Item
                {
                    Name = "Vegan Fish and Chips",
                    Price = 180,
                    Description = "Crispy beer-battered tofu ‘fish’ with golden fries and vegan tartar sauce.",
                    ImageUrl = "/images/fishandchips.jpg"
                },
                new Item
                {
                    Name = "Vegan Tacos",
                    Price = 140,
                    Description = "Soft tortillas filled with spiced lentils, avocado, and fresh salsa.",
                    ImageUrl = "/images/tacos.jpg"
                }
            };
            context.AddRange(items);
            context.SaveChanges();
        }

        if (!context.Customers.Any())
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Name = "Alice Hansen",
                    Address = "Osloveien 1"
                },

                new Customer
                {
                    Name = "Bob Johansen",
                    Address = "OslometGata 3"
                }
            };
            context.AddRange(customers);
            context.SaveChanges();
        }

        if (!context.Orders.Any())
        {
            var orders = new List<Order>
            {
                new Order
                {
                    OrderDate = DateTime.Today.ToString(),
                    CustomerId = 1,
                },

                new Order
                {
                    OrderDate = DateTime.Today.ToString(),
                    CustomerId = 2,
                }
            };
            context.AddRange(orders);
            context.SaveChanges();
        }

        if (!context.OrderItems.Any())
        {
            var orderItems = new List<OrderItem>
            {
                new OrderItem { ItemId = 1, Quantity = 2, OrderId = 1},
                new OrderItem { ItemId = 2, Quantity = 1, OrderId = 1},
                new OrderItem { ItemId = 3, Quantity = 4, OrderId = 2},
            };
            foreach (var orderItem in orderItems)
            {
                var item = context.Items.Find(orderItem.ItemId);
                orderItem.OrderItemPrice = orderItem.Quantity * item?.Price ?? 0;
            }
            context.AddRange(orderItems);
            context.SaveChanges();
        }

        var ordersToUpdate = context.Orders.Include(o => o.OrderItems);
        foreach (var order in ordersToUpdate)
        {
            order.TotalPrice = order.OrderItems?.Sum(oi => oi.OrderItemPrice) ?? 0;
        }
        context.SaveChanges();
    }
}
