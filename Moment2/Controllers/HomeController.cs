using Microsoft.AspNetCore.Mvc;
using Moment2.Models;
using Newtonsoft.Json;

namespace Moment2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var jsonStr = System.IO.File.ReadAllText("bands.json");
            var jsonObj = JsonConvert.DeserializeObject<List<Bands>>(jsonStr);

            return View(jsonObj);
        }

        [Route("/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost("/add")]
        public IActionResult Add(Bands model)
        {
            if (ModelState.IsValid)
            {
                var jsonStr = System.IO.File.ReadAllText("bands.json");
                var jsonObj = JsonConvert.DeserializeObject<List<Bands>>(jsonStr);

                if (jsonObj != null)
                {
                    jsonObj.Add(model);
                    System.IO.File.WriteAllText("bands.json", JsonConvert.SerializeObject(jsonObj, Formatting.Indented));

                    ModelState.Clear();
                }
            } 

            return View();
        }

        [Route("/genres")]
        public IActionResult Genres()
        {
            List<string> Genres = new List<string>
            {
                "Heavy metal",
                "Power metal",
                "Folk metal",
                "Death metal",
                "Black metal",
                "Progressive metal"
            };

            ViewBag.Genres = Genres;
            return View();
        }
    }
}