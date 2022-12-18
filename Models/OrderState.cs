namespace SharknessShop.Models
{
	/* 1. Completed
	 * 2. Processing
	 * 3. Uncompleted (still adding products or else)
	 */
	public class OrderState
	{
		public int Id { get; set; }
		public string StateName { get; set; }
		public ICollection<Order> Orders { get; set; }

		public OrderState()
		{
			Orders = new List<Order>();
		}
	}
}
