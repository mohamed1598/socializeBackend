using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Socialize.Models
{
    public class Package
    {
        public Package()
        {
            Id = Guid.NewGuid();
            Title = "";
            UserId = "";
            User = new();
            UserName = "";
            Email = "";
            PersonalWebsite = "";
            PhoneNumber = "";
            Facebook = "";
            Instagram = "";
            Twitter = "";
            GitHub = "";
            Linkedin = "";
        }
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Title { get; set; } //title of package
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PersonalWebsite { get; set; }
        public string PhoneNumber { get; set; }
        public string Facebook { get; set; }
        public string Instagram { get; set; }
        public string Twitter { get; set; }
        public string GitHub { get; set; }
        public string Linkedin { get; set; }

        [Required]
        public string UserId { get; set; }
        public User User { get; set; }

    }
}
