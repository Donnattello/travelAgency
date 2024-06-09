using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using travelAgency.Data;
using travelAgency.Model;
using static Humanizer.In;

namespace travelAgency.Pages
{

    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _db;

        // Jeden konstruktor, który przyjmuje oba zależności
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IList<tour> ListTours { get; set; }
        public IList<tour> ALlTours { get; set; }

        public async Task OnGetAsync()
        {
            ALlTours = await _db.Tours.ToListAsync();
            ListTours = await _db.Tours
                .OrderByDescending(t => t.CreatedAt)
                .Take(3)
                .ToListAsync();
           
        }

        
    }
}