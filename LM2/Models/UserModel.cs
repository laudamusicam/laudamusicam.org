using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LaudaMusicam.Models
{
    public class UserModel
    {
        [Key]
        [Required]
        public virtual int Id { get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "User name cannot be longer that 50 characters")]
        public virtual string UserName { get; set; }

        public virtual ICollection<RoleModel> Roles { get; set; }
    }
}