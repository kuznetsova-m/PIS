using System;
using RoadmapApp.Enums;

namespace RoadmapApp.Models
{
    public class User
    {
        public string Phone { get; set; }
        public string Password { get; set; }

        public Purpose Purpose { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime? PatentDate { get; set; } 

        public RoadMap RoadMap { get; set; } = new RoadMap();

        public User() { }

        public User(string phone, string password)
        {
            Phone = phone;
            Password = password;
        }
    }
}
