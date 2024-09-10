using Microsoft.AspNetCore.Mvc;
using Practice_Basic_MVC.Models;
using Practice_Basic_MVC.ViewModel;

namespace Practice_Basic_MVC.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customer = new Customer
            {
                Id = 1,
                FirstName = "Atakan",
                LastName = "Çelik",
                Email = "atakancelik@ornek.com"
            };

            var orders = new List<Order>();
            orders.Add(new Order
            {
                Id = 1,
                ProductName = "Telefon",
                Price = 45000,
                Quantity = 1,
            });
            orders.Add(new Order
            {
                Id = 2,
                ProductName = "Bilgisayar",
                Price = 60000,
                Quantity = 2,
            });

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customer,
                Orders = orders
            };
            return View(viewModel);
        }
    }
}
