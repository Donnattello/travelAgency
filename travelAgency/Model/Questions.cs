using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace travelAgency.Model
{
    public class Questions
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "field is required!")]
       
        public string Name { get; set; }
        public string Email { get; set; }
        public int Question { get; set; }
        public bool State { get; set; }
        
    }
}
