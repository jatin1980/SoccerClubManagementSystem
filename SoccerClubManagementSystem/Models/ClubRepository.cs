using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerClubManagementSystem.Models
{
    //This is ClubRepository 
    public class ClubRepository
    {

        List<Club> Clublist = new List<Club>();
        public ClubRepository()
        { 
            //Filling Initial data and Used session to 
            //maintain data between two request
            List<Club> lst = (List<Club>)HttpContext.Current.Session["clb"];
            if (lst == null)
            {
                Clublist.Add(new Club { ClubId = 101, ClubName = "Raj Path", ClubAddress = "H.G Highway Ahmedabad", Clubcontact = "917391390", ClubEmail = "test@rajpath.com", ClubContactPerson = "Jimmy", ClubCity = "Ahmedabad" });
                Clublist.Add(new Club { ClubId = 102, ClubName = "Silver", ClubAddress = "Gota Cross Raod", Clubcontact = "817391390", ClubEmail = "test@silver.com", ClubContactPerson = "nimesh", ClubCity = "Ahmedabad" });
                Clublist.Add(new Club { ClubId = 102, ClubName = "Alpha", ClubAddress = "London Cross Raod", Clubcontact = "717391397", ClubEmail = "test@silver.com", ClubContactPerson = "Jigar", ClubCity = "London" });
                Clublist.Add(new Club { ClubId = 102, ClubName = "Gujarat", ClubAddress = "Vijay Cross Raod", Clubcontact = "917891390", ClubEmail = "test@silver.com", ClubContactPerson = "Nelson", ClubCity = "Delhi" });
                Clublist.Add(new Club { ClubId = 102, ClubName = "Potter", ClubAddress = "Gota Cross Raod", Clubcontact = "918391398", ClubEmail = "test@silver.com", ClubContactPerson = "ritika", ClubCity = "Auuckland" });
                HttpContext.Current.Session["clb"] = Clublist;
            }
        }
        public IEnumerable<Club> GetClubs()
        {
            List<Club> lst = (List<Club>)HttpContext.Current.Session["clb"];

            return lst;
        }
        public Club GetClubByID(int id)
        {
            List<Club> lst = (List<Club>)HttpContext.Current.Session["clb"];
            Club club = null;
            foreach (Club c in lst)
            {
                if (c.ClubId == id)
                {
                    club = c;
                    break;
                }
            }
            return club;
        }
        public void InsertClub(Club club)
        {
            List<Club> lst = (List<Club>)HttpContext.Current.Session["clb"];

            lst.Add(club);
            HttpContext.Current.Session["clb"] = lst;
        }
        




    }
}