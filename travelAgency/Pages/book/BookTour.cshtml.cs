using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using travelAgency.Data;
using travelAgency.Model;

namespace travelAgency.Pages.book
{
    [Authorize]
    public class BookTourModel : PageModel
    {


        private readonly ApplicationDbContext _db;

        public BookTourModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public booking Book { get; set; }
		
		public string SelectedTourId { get; set; }
		public List<SelectListItem> Tours { get; set; }


		public void OnGet()
		{
			Tours = _db.Tours.Select(t => new SelectListItem
			{
				Value = t.Id.ToString(),
				Text = t.Country.ToString()+ " " + " " + t.Date.ToString() ,
			}).ToList();
		}

		//public SelectList Tours { get; set; }

		//public async Task OnGetAsync()
		//{
		//	var tours = await _db.Tours.ToListAsync();
		//	Tours = new SelectList(tours, "Id", "Country"); // "Id" is the value field, "Country" is the text field
		//}


		public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
				
				return Page();
			}
			Book.NameTour = 3;
			_db.BookT.Add(Book);
            await _db.SaveChangesAsync();
            return RedirectToPage("/travel/tours");
        }

    }
}
