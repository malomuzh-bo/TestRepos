namespace SharknessShop.Models
{
	/* 1. Client
	 * 2. Admin
	 */
	public class UserState
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public ICollection<User> Users { get; set; }

		public UserState()
		{
			Users = new List<User>();
		}
	}
}
