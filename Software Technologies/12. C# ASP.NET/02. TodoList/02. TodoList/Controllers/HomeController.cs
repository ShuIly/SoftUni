﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using _02.TodoList.Models;

namespace _02.TodoList.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			using (var db = new TaskDbContext())
			{
				var tasks = db.Tasks.ToList();

				return View(tasks);
			}
		}
	}
}