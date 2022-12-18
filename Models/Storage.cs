namespace SharknessShop.Models
{
	public class Storage
	{
		public int Id { get; set; }
		public ICollection<Product> Products { get; set; }
		public float Price { get; set; }

		public Storage()
		{
			Products = new List<Product>();
		}
		public void totalPrice()
		{
			if (Amount <= 0)
			{
				return;
			}
			else
			{
				float total = Amount * Price;
			}
		}
	}
}
