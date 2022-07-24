using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaudaMusicam.Models
{
    public class ImageGallery
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }

        public virtual ICollection<Image> Images { get; set; }
    }
}