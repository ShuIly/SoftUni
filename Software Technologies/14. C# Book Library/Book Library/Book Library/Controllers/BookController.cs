using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Book_Library.Models;
using Microsoft.AspNet.Identity;

namespace Book_Library.Controllers
{
    public class BookController : Controller
    {
		[HttpGet]
        public ActionResult Index()
        {
	        using (var db = new ApplicationDbContext())
	        {
		        var books = db.Books.ToList();

				return View(books);
	        }
        }

        // GET: Book/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Book/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Book/Create
        [HttpPost]
        public ActionResult Create(Book book)
        {
	        using (var db = new ApplicationDbContext())
	        {
		        var userId = User.Identity.GetUserId();

		        book.AuthorId = userId;

		        db.Books.Add(book);
		        db.SaveChanges();

				return RedirectToAction("Index");
	        }
        }

        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Book/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Book/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Book/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
