using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication7.Models
{
    public class President
    {
        public string PresidentName { get; set; }
        public string BirthDay { get; set; }
        public string BirthPlace { get; set; }
        public string DeathDay { get; set; }
        public string DeathPlace { get; set; }

        //public President(string Name, string Birthday, string BirthPlace, string Deathday, string DeathPlace)
        //{
        //    this.PresidentName = Name;
        //    this.BirthDay = Birthday;
        //    this.BirthPlace = BirthPlace;
        //    this.DeathDay = Deathday;
        //    this.DeathPlace = DeathPlace;
        //}
    }
}