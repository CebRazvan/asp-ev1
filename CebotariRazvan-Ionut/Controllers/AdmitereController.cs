using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CebotariRazvan_Ionut.Controllers
{
    public class AdmitereController : Controller
    {
        // GET: AdmitereController
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        // POST: AdmitereController/Create
        [HttpPost]
        public IActionResult Index(double limInstruire, double limStraina, double matematica, double informatica, double mediaExamAbsolvire)
        {
            if (limInstruire <= 0 || limStraina <= 0 || matematica <= 0 || informatica <= 0 || mediaExamAbsolvire <= 0)
            {
                return View("Index", "Introduceti toate datele!");
            }

            double media = (limInstruire + limStraina + matematica + informatica + mediaExamAbsolvire) / 5;
            return View("Index" ,$"Media dumneavoastra de concurs este: {media:F2}");
        }
    }
}
