using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.Films;

namespace WebApplication1.Controllers
{
    public class FilmsRecommendationsController : Controller
    {
        // GET: FilmsRecommendations

        private FilmsContext db = new FilmsContext();
        public ActionResult Index()
        {
            return View(db.genres.ToList());
        }

        public ActionResult Recommend()
        {
            int id=0;
            
            if(int.TryParse(Request.Params["genre"],out id))
            {
                var f = db.genres.Find(id);
                if (f != null)
                {
                    var recommendation = new Recommendation
                    {
                        GenreName = f.name,
                        films = f.films.ToList()
                    };
                    return View(recommendation);
                }
            }
            return View("Index");
        }
    }
}