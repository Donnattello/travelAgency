using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;

namespace travelAgency.Model
{
    public class tour
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "field is required!")]
        [Display(Name = "Tour Name")]
        public string Imgg { get; set; }
        public string Country { get; set; }
        public int Duration { get; set; }
        public string Date { get; set; }
        public int AmountOfPeople { get; set; }
        public double price { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    
}
