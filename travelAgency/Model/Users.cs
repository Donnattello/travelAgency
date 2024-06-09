using Humanizer;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.ContentModel;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data;
using System.Xml.Linq;

namespace travelAgency.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string UName { get; set; }

        public string ULastName { get; set; }

        public string UTel { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        [EmailAddress]
        public string UEmail { get; set; }

        [Required(ErrorMessage = "Field is required!")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        public string UPassword { get; set; }

		public string Usex { get; set; }

    
       

        public string URole { get; set; }
    }
}

