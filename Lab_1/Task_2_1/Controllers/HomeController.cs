using Microsoft.AspNetCore.Mvc;
using Task_2_1.Data;      
using Task_2_1.Models;    

namespace Task_2_1.Controllers
{
    public class HomeController : Controller
    {
        // �������� �� ���� �� �������� ����� DI
        private readonly ApplicationDbContext _context;

        // ������ ���� ������ �������� ��
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Home/Index
        [HttpGet]
        public IActionResult Index()
        {
            // ��������� ������� ������� � ������
            return View();
        }

        // POST: Home/IndexPost ³������� ����� �����
        [HttpPost]
        public IActionResult IndexPost()
        {
            // ������� URL-������ � �����
            string image1Url = Request.Form["image1Url"];
            string image2Url = Request.Form["image2Url"];
            string image3Url = Request.Form["image3Url"];
            string image4Url = Request.Form["image4Url"];
            string image5Url = Request.Form["image5Url"];

            // �������� ������ ��������� � ��
            var dim1 = _context.ImageDimensions.Find(1);
            var dim2 = _context.ImageDimensions.Find(2);
            var dim3 = _context.ImageDimensions.Find(3);
            var dim4 = _context.ImageDimensions.Find(4);
            var dim5 = _context.ImageDimensions.Find(5);

            // �������� URL-������ ��������� � ViewBag 
            ViewBag.Image1Url = image1Url;
            ViewBag.Image2Url = image2Url;
            ViewBag.Image3Url = image3Url;
            ViewBag.Image4Url = image4Url;
            ViewBag.Image5Url = image5Url;

            // �������� ������ ��������� � �� � ViewBag
            ViewBag.Image1Width = dim1?.Width ?? "80px";
            ViewBag.Image1Height = dim1?.Height ?? "60px";

            ViewBag.Image2Width = dim2?.Width ?? "100px";
            ViewBag.Image2Height = dim2?.Height ?? "80px";

            ViewBag.Image3Width = dim3?.Width ?? "120px";
            ViewBag.Image3Height = dim3?.Height ?? "100px";

            ViewBag.Image4Width = dim4?.Width ?? "140px";
            ViewBag.Image4Height = dim4?.Height ?? "120px";

            ViewBag.Image5Width = dim5?.Width ?? "160px";
            ViewBag.Image5Height = dim5?.Height ?? "140px";

            // ��������� ������� Display � ���� ���������� ������
            return View("Display");
        }

        // ���������� ���� ��� �����������
        public IActionResult Display()
        {
            return View();
        }
    }
}
