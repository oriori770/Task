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
        [Route("{search}/{results}")]
        public string searchResults(string results, string search)
        {
            return $"{search}/{results}";
        }
        [Route("report/summary/{year}")]
        public string Year(int year, string type)
        {
            return $"Year: {year}, Report Type: {type}";
        }
        [Route("invoice/view/{invoiceId}")]
        public string invoice(int invoiceId, bool paid)
        {
            return $"Invoice ID: {invoiceId}, Paid: {paid}";
        }
        [Route("store/item/{itemId}")]
        public string store(int itemId, string category)
        {
            return $"\"Item ID: {itemId}, Category: {category}";
        }
        [Route("blog/post/{postId}")]
        public string blog(int postId, string title)
        {
            return $"Post ID: {postId}, Title: {title}.";
        }
        [Route("checkout/process")]
        public string checkout(int cartId, bool discount)
        {
            return $"Cart ID: {cartId}, Discount Applied: {discount}.";
        }
        [Route("location/details/{locationId}")]
        public string location(int locationId, string type, int population)
        {
            return $"\"Location ID: {locationId}, Type: {type}, Population: {population}";
        }
        [Route("logUTMs")]
        public string bonus()
        {
            return Request.QueryString.ToString();
        }

        //Request.QueryString.ToString();
        //ricest.querypopulation
    }
}
