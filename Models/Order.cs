using System.Xml.Schema;

namespace SharknessShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User? User { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; }
        public float Price { get; set; }
        public int OrderStateId { get; set; }
        public virtual OrderState? OrderState { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime DateUpdate { get; set; }
        public Order()
        {
            DateCreate = DateTime.Now;
            ProductOrders = new List<ProductOrder>();
        }
        public void updDate()
        {
            DateUpdate = DateTime.Now;
        }
    }
}
