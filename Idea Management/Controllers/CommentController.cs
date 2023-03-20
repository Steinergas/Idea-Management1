using Idea_Management.Models;
using Idea_Management.Models.comment;
using System.Data.SqlClient;
using System.Linq;
using System.Web.Mvc;

namespace Idea_Management.Controllers
{
    public class CommentController : Controller
    {

       private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Ideas
        public ActionResult Index()
        {

            return View(db.Ideas.ToList());
        }
        [HttpPost]
        public ActionResult Create([Bind(Include = "Id, Comment")] Ideas ideas)
        {
            if (ModelState.IsValid)
            {
                db.Ideas.Add(ideas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ideas);
        }
    }
}