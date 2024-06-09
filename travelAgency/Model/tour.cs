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
        [Required(ErrorMessage = "field is required!")]
        public string Country { get; set; }
        [Required(ErrorMessage = "field is required!")]
        public int Duration { get; set; }
        [Required(ErrorMessage = "field is required!")]
        public string Date { get; set; }
        [Required(ErrorMessage = "field is required!")]
        public int AmountOfPeople { get; set; }
        [Required(ErrorMessage = "field is required!")]
        public int available { get; set; }
        [Required(ErrorMessage = "field is required!")]
        public double price { get; set; }
        [Required(ErrorMessage = "field is required!")]
        public DateTime CreatedAt { get; set; }
    }

    
}
