
namespace SimpleApp.Controllers
{
    [ApiController]
    [Route("/")]
    public class HomeController : Controller
    {
        public IDataSource dataSource = new ProductDataSource();
        public ViewResult Index()
        {
            return View("Index", dataSource.Products);
        }
    }
}
