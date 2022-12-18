using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace SharknessShop.Models
{
	public class ShopContext : DbContext
	{
		public DbSet<User>				Users { get; set; }
		public DbSet<Order>				Orders { get; set; }
		public DbSet<Product>			Products { get; set; }
		public DbSet<Storage>			Storages { get; set; }
		public DbSet<UserState>			UserStates { get; set; }
		public DbSet<OrderState>		OrderStates { get; set; }
		public DbSet<ProductPic>		ProductPics { get; set; }
		public DbSet<ProductOrder>		ProductOrders { get; set; }
		public DbSet<ProductCategory>	ProductCategories { get; set; }

		public ShopContext()
		{

		}
		public ShopContext(DbContextOptions<ShopContext> opt) : base(opt)
		{
			Database.EnsureCreated();
		}
	}
}
