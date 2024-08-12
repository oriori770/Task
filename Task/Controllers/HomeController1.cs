using Microsoft.AspNetCore.Mvc;

namespace Task.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("product/{id}")]
        public string product(int id, bool hasItem)
        {
            return $"Product ID: {id}, Has Item: {hasItem}";
        }
        [Route("order/confirm/{orderId}")]
        public string order(int orderId, string Status)
        {
            return $"Order ID: {orderId}, Status: {Status}";
        }
        [Route("user/profile/{username}")]
        public string profile(int age, string username)
        {
            return $"Username: {username}, Age: {age}";
        }

        //ricest.query
    }
}
