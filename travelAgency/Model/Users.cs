using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace travelAgency.Model
{
    public class Users
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string Status { get; set; }
    }
}
