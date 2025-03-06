using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;           
using Task_4.Models;           

namespace Task_4.Controllers
{
    public class HomeController : Controller
    {
        // ������
        private readonly ILogger<HomeController> _logger;

        // ������ ���� ������ ������ ����� dependency injection
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        // ĳ� ��� ������� �������
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // ĳ� ��� ������� �������
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            // ��������� ��'��� ErrorViewModel � RequestId
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
