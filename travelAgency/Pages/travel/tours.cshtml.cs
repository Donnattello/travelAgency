using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using travelAgency.Data;
using travelAgency.Model;
using static Humanizer.In;

namespace travelAgency.Pages.travel
{
    
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        // Jeden konstruktor, który przyjmuje oba zale¿noœci
        public IndexModel(ApplicationDbContext db)
        {
           
            _db = db;
        }

        public IList<tour> AllTours { get; set; }

        public async Task OnGetAsync()
        {
           
            AllTours = await _db.Tours.ToListAsync();
        }
       
        
    }
    
}
