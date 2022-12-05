
namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index", Product.GetProducts());
        }
    }
}
