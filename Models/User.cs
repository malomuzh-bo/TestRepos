namespace SharknessShop.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Pass { get; set; }
        public int UserStateId { get; set; }
        public virtual UserState? UserState { get; set; }
        public ICollection<Order> Orders { get; set; }

        public User(int id, string login, string pass, int userStateId, UserState? userState, ICollection<Order> orders)
        {
            Id = id;
            Login = login;
            Pass = pass;
            UserStateId = userStateId;
            UserState = userState;
            Orders = orders;
        }
        public User()
        {
            Orders = new List<Order>();
            UserStateId = 1;
        }
    }
}
