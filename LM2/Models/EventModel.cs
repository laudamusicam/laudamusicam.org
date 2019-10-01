using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LaudaMusicam.Models
{
    public class EventModel
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        public virtual DateTime Time { get; set; }

        public virtual DateTime? EndTime { get; set; }

        public virtual DateTime? Time2 { get; set; }

        public virtual DateTime? EndTime2 { get; set; }

        public virtual string TimeZoneId { get; set; }

        public virtual string Name { get; set; }

        public virtual string Description { get; set; }

        public virtual Address Address { get; set; }

        public virtual string Comment1 { get; set; }

        public virtual string LinkText { get; set; }
        public virtual string LinkHRef { get; set; }
        public virtual string LinkText2 { get; set; }
        public virtual string LinkHRef2 { get; set; }

        public DateTime GetLocalTime(DateTime t)
        {
            var tz = TimeZoneInfo.FindSystemTimeZoneById(TimeZoneId);
            if (tz == null)
            {
                tz = TimeZoneInfo.FindSystemTimeZoneById("EST");
            }
            return TimeZoneInfo.ConvertTimeFromUtc(t, tz);
        }
    }
}