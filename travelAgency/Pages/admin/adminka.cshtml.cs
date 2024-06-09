using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using travelAgency.Data;
using travelAgency.Model;

namespace travelAgency.Pages.admin
{
    public class adminkaModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        // Jeden konstruktor, który przyjmuje oba zale¿noœci
        public adminkaModel(ApplicationDbContext db)
        {

            _db = db;
        }

        public IList<BookingViewModel> AllReservations { get; set; }
        

        public async Task OnGetAsync()
        {
            
            AllReservations = await _db.BookT
            .Select(b => new BookingViewModel
            {
                Id = b.Id,
                Name = b.Name,
                LastName = b.LastName,
                Tel = b.Tel,
                Email = b.Email,
                sex = b.sex,
                age = b.age,
                Status = b.Status,
                Country = _db.Tours.FirstOrDefault(t => t.Id == b.NameTour).Country,
                available = _db.Tours.FirstOrDefault(t => t.Id == b.NameTour).available,
                AmountOfPeople = _db.Tours.FirstOrDefault(t => t.Id == b.NameTour).AmountOfPeople
           
           })
            .ToListAsync();

        }






        public async Task<IActionResult> OnPostAcceptAsync(int id)
        {
            var booking = await _db.BookT.FindAsync(id);
            if (booking == null)
            {
                return NotFound();
            }

            booking.Status = "accepted";
            await _db.SaveChangesAsync();


            if (booking != null)
            {



                var tourId = booking.NameTour; // Pobierz ID wycieczki z rezerwacji
                var tour = await _db.Tours.FindAsync(tourId);
                if (tour != null)
                {
                    tour.available -= 1; // Zmniejsz dostêpnoœæ w tabeli Tour
                    await _db.SaveChangesAsync();
                }
            }

            return RedirectToPage();
        }

        public async Task<IActionResult> OnPostRejectAsync(int id)
        {
            var booking = await _db.BookT.FindAsync(id);
            if (booking != null)
            {
                booking.Status = "reject"; // Ustaw status na "reject"
                await _db.SaveChangesAsync();
            }

            return RedirectToPage();
        }

    }
    public class BookingViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Tel { get; set; }
        public string Email { get; set; }
        public string sex { get; set; }
        public int age { get; set; }
        public string Status { get; set; }
        public string Country { get; set; }
        public int available { get; set; }
        public int AmountOfPeople { get; set; }
    }
}
