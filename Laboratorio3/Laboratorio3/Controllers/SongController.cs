using Laboratorio3.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace Laboratorio3.Controllers
{
    public class SongController : Controller
    {
        public IActionResult Index()
        {
            var song = GetSong();
            ViewBag.MainTitle = "My Favourite Song";
            return View(song);
        }

        private SongModel GetSong()
        {
            var song = new SongModel();
            song.Name = "Radioactive";
            song.Genre = "Alternative Rock";
            song.Author = "Imagine Dragons";
            song.Album = "Night Visions (Deluxe)";
            song.ReleasedDate = new DateTime(2014, 01, 27);

            return song;
        }
    }
}
