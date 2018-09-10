using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMovie.Models
{
    public class Login
    {

        public int ID { get; set; }

        //[RegularExpression(@"^[A-Z]+[a-zA-Z'\s]+[0-9]*$")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9_]+$")]
        [MinLength(6)]
        [MaxLength(15)]
        public string UserName { get; set; }

        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9_]+$")]
        [MinLength(6)]
        [MaxLength(15)]
        public string UserPassword { get; set; }

        [StringLength(40)]
        public string Email { get; set; }

        [RegularExpression(@"^[0-9]*$")]
        [StringLength(4)]
        public string UserPasswordSecurity { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}")] // ,ApplyFormatInEditMode = false ,HtmlEncode = false
        public DateTime ReleaseDate { get; set; }


    }
    public class LoginDBContext : DbContext
    {
        public DbSet<Login> Logins { get; set; }
    }
}