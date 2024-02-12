using CommandGenerator.DAL;
using CommandGenerator.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CommandGenerator.Controllers
{
    public class EnchantmentController : Controller
    {
        private EnchantmentContext db = new EnchantmentContext();

        // GET: Enchantment
        public ActionResult Index(string sortOrder, string searchString, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.TypeSortParam = string.IsNullOrEmpty(sortOrder) ? "type_desc" : "";
            ViewBag.ItemSortParam = sortOrder == "Item" ? "item_desc" : "Item";
            ViewBag.LevelSortParam = sortOrder == "Level" ? "level_desc" : "Level";
            ViewBag.CreatorSortParam = sortOrder == "Creator" ? "creator_desc" : "Creator";

            var enchantments = db.Enchantments.AsQueryable();

            if (!string.IsNullOrEmpty(searchString))
            {
                enchantments = enchantments.Where(e => e.Type.ToString().Contains(searchString) || e.Item.ToString().Contains(searchString) || e.Creator.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "type_desc":
                    enchantments = enchantments.OrderByDescending(e => e.Type);
                    break;
                case "Item":
                    enchantments = enchantments.OrderBy(e => e.Item);
                    break;
                case "item_desc":
                    enchantments = enchantments.OrderByDescending(e => e.Item);
                    break;
                case "Level":
                    enchantments = enchantments.OrderBy(e => e.Level);
                    break;
                case "level_desc":
                    enchantments = enchantments.OrderByDescending(e => e.Level);
                    break;
                case "Creator":
                    enchantments = enchantments.OrderBy(e => e.Creator);
                    break;
                case "creator_desc":
                    enchantments = enchantments.OrderByDescending(e => e.Creator);
                    break;
                default:
                    enchantments = enchantments.OrderBy(e => e.Type);
                    break;
            }

            int pageSize = 3;
            int pageNumber = (page ?? 1);
            return View(enchantments.ToPagedList(pageNumber, pageSize));
        }

        // GET: Enchantment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Enchantment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Enchantment enchantment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Enchantments.Add(enchantment);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(enchantment);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index"); 
            }
        }

        // GET: Enchantment/Edit/5
        public ActionResult Edit(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Enchantment enchantment = db.Enchantments.Find(id);
                if (enchantment == null)
                {
                    return HttpNotFound();
                }
                return View(enchantment);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index"); 
            }
        }

        // POST: Enchantment/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Enchantment enchantment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    db.Entry(enchantment).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(enchantment);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index");
            }
        }

        // GET: Enchantment/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Enchantment enchantment = db.Enchantments.Find(id);
                if (enchantment == null)
                {
                    return HttpNotFound();
                }
                return View(enchantment);
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index"); 
            }
        }

        // POST: Enchantment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            try
            {
                Enchantment enchantment = db.Enchantments.Find(id);
                db.Enchantments.Remove(enchantment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                
                return RedirectToAction("Index"); 
            }
        }

        public ActionResult Details(int? id)
        {
            try
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Enchantment enchantment = db.Enchantments.Find(id);
                if (enchantment == null)
                {
                    return HttpNotFound();
                }
                return View(enchantment);
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index"); 
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
