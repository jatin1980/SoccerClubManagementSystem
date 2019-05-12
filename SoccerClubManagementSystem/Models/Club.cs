using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerClubManagementSystem.Models
{
    //This is Club Model
    public class Club
    {
        public int ClubId { get; set; }
        public string ClubName { get; set; }
        public string ClubAddress { get; set; }
        public string Clubcontact { get; set; }
        public string ClubEmail { get; set; }
        public string ClubContactPerson { get; set; }
        public string ClubCity { get; set; }
    }
}