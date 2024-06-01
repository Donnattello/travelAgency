using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using travelAgency.Data;
using travelAgency.Model;

namespace travelAgency.Pages.travel
{
    public class TourPageModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        // Jeden konstruktor, który przyjmuje oba zale¿noœci
        public TourPageModel(ApplicationDbContext db)
        {

            _db = db;
        }
        public List<days> ListDays { get; set; }
        public tour Tour { get; set; }

        public IActionResult OnGet(int id)
        {
            Tour = _db.Tours.FirstOrDefault(t => t.Id == id);
            ListDays = _db.Days.Where(d => d.idtour == id).ToList();
            if (Tour == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
