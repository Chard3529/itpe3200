using System;
namespace MyShop.Models
{
	public class Item
	{
		public int ItemId { get; set; }
		public string Name { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public string? Description { get; set; }
		public string? ImageUrl { get; set; }

		public Item(int ItemId, String Name, decimal Price)
		{
			this.ItemId = ItemId;
			this.Name = Name;
			this.Price = Price;
		}
	}
}