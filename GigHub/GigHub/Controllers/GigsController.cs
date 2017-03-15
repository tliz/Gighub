﻿using GigHub.Models;
using GigHub.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Linq;
using System.Web.Mvc;

namespace GigHub.Controllers
{
    public class GigsController : Controller
    {
        // 1. 
        private readonly ApplicationDbContext _context;

        // initialize constructor
        public GigsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Gigs
        [Authorize]
        public ActionResult Create()
        {
            // get list of genres from the database
            // 1. DbContext
            // 2. Create view model and set genre property
            var viewModel = new GigFormViewModel
            {
                Genres = _context.Genres.ToList()
            };

            return View(viewModel);
        }

        // form model behind view. When form is posted that is what we are going to get
        [Authorize]
        [HttpPost]  // Action to be called only via post method
        public ActionResult Create(GigFormViewModel viewModel)
        {
            // convert viewModel to gig object 
            // Add to context
            // save changes


            // var artistId = User.Identity.GetUserId();

            // fetch values from database. but will issue 2 queries to database
           // var artist = _context.Users.Single(u => u.Id == artistId);
            //var genre = _context.Genres.Single(g => g.Id == viewModel.Genre);

            // Gig object
            var gig = new Gig
            {
                ArtistId = User.Identity.GetUserId(),
                DateTime = DateTime.Parse(string.Format("{0}, {1}", viewModel.Date, viewModel.Time)),
                GenreId = viewModel.Genre,
                Venue = viewModel.Venue
            };

            //Add it to context
            _context.Gigs.Add(gig);

            // save changes
            _context.SaveChanges();

            // Redirect to HomePage
            return RedirectToAction("Index", "Home");
        }
    }
}