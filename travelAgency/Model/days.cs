using System.ComponentModel.DataAnnotations;

namespace travelAgency.Model
{
    public class days
    { 
        [Key]
        public int Id { get; set; }
        public int idtour { get; set; }
        public string Dimg { get; set; }
        public int number { get; set; }
        public string description { get; set; }

    }
}
