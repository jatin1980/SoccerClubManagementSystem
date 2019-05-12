using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SoccerClubManagementSystem.Models
{
    //This is Player Model
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public string Email { get; set; }
        public int JoinMonth { get; set; }
        public int JoinYear { get; set; }
        public int JoinDay { get; set; }


    }
}