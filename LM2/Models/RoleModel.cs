using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LaudaMusicam.Models
{
    public class RoleModel
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        public virtual ICollection<UserModel> Users { get; set; }
    }
}