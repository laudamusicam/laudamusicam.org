using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LaudaMusicam.Models
{
    public class HomePageModel
    {
        public ICollection<EventModel> Events { get; set; }
    }
}