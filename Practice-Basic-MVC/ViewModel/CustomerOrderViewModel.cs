using Practice_Basic_MVC.Models;

namespace Practice_Basic_MVC.ViewModel
{
    public class CustomerOrderViewModel
    {
         public Customer Customer { get; set; }
         public List<Order> Orders { get; set; }
    }
}
