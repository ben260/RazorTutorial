using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTutorialWeb.Data;
using RazorTutorialWeb.Model;

namespace RazorTutorialWeb.Pages.Categories
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Category Category { get; set; }
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }
        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (Category.Name == Category.DisplayOrder.ToString())
            {
                ModelState.AddModelError("Category.Name", "Can't be the same bro");
            }
            if (ModelState.IsValid)
            {
                await _db.Category.AddAsync(Category);
                await _db.SaveChangesAsync();
                TempData["success"] = "Category created successfully";
                return RedirectToPage("Index");
            }
            return Page();
            
        }


    }
}
