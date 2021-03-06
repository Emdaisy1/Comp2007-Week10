﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Comp2007_Week10.Models;

namespace Comp2007_Week10.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreContext storeDB = new MusicStoreContext();
        //
        // GET: /Store/
        public ActionResult Index()
        {
            List<Genre> genres = storeDB.Genres.ToList();
            return View(genres);
        }        
        //
        // GET: /Store/Browse?genre=Disco
        public ActionResult Browse(string genre = "Alternative")
        {
            // Retrieve Genre (single instance) and its Associated Albums from database
            Genre genreModel = storeDB.Genres.Include("Albums").Single(g => g.Name == genre);

            return View(genreModel);
        }
        //
        // GET: /Store/Details/5
        public ActionResult Details(int id = 1)
        {
            Album album = storeDB.Albums.Find(id);

            return View(album);
        }
    }
}