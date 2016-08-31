using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaudaMusicam.Models
{
    public class Image
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        public virtual string ThumbnailUrl { get; set; }

        public virtual string HalfPageWidthUrl { get; set; }
        public virtual string FullPageWidthUrl { get; set; }

        public virtual string HighResUrl { get; set; }

        public int WidthInPixels { get; set; }
        public int HeightInPixels { get; set; }
    }
}