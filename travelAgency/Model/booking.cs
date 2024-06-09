using System.ComponentModel.DataAnnotations;

namespace travelAgency.Model
{
	public class booking
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage = "field is required!")]
		public int NameTour { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string Tel { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string sex { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public int age { get; set; }

        [Required(ErrorMessage = "field is required!")]
        public string Status { get; set; } = "send";
	}
}
