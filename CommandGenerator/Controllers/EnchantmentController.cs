using CommandGenerator.DAL;
using CommandGenerator.Models;
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
        public ActionResult Index()
        {
            try
            {
                var enchantments = db.Enchantments.ToList();
                return View(enchantments);
            }
            catch (Exception ex)
            {

                return RedirectToAction("Index"); 
            }
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
