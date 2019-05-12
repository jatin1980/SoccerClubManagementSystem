using SoccerClubManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace SoccerClubManagementSystem.Controllers
{
    public class ClubController : Controller
    {
        private static int clubnumber = 103;
        //instance of repository 
        ClubRepository crepo = new ClubRepository();

        //This method load list of club using GetClub method of repository
        public ActionResult Index()
        {

            return View(crepo.GetClubs());
        }


        //This is get method for Addclub method 
        public ActionResult AddClub()
        {
            return View();
        }

        //This is post method for Addclub method 
        //This method add new Club to clublist 
        //using InsertCluub method
        [HttpPost]
        public ActionResult AddClub(Club club)
        {
            club.ClubId = Seq();

            crepo.InsertClub(club);
            return RedirectToAction("Index");
        }

        //This method display details of Club Single club
        public ActionResult Details(int id)
        {

            return View(crepo.GetClubByID(id));
        }

        //This is generating club id 
        int Seq()
        {
            return Interlocked.Increment(ref clubnumber);
        }
    }
}