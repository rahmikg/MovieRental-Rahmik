using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext _context;

        public RentalsController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: New Rentals Form
        public ActionResult New()
        {
            return View();
        }


        public ViewResult Index()
        {
            var rentals = _context.Rentals.Include(c => c.Movie).ToList();
            var namerentals = _context.Rentals.Include(c => c.Customer).ToList();
            //var rentals = _context.Rentals.Include(c => c.Id);
            return View(rentals);

        }



    }
}