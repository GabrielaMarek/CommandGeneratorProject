using CommandGenerator.DAL;
using CommandGenerator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CommandGenerator.Controllers
{
    public class CommentController : Controller
    {
        private EnchantmentContext db = new EnchantmentContext();

        // GET: Comment
        public ActionResult Index()
        {
            var comments = db.Comments.ToList();
            return View(comments);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                comment.CreatedAt = DateTime.Now;
                db.Comments.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comment);
        }
    }

}