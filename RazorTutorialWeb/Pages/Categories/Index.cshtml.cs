using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorTutorialWeb.Data;
using RazorTutorialWeb.Model;

namespace RazorTutorialWeb.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _db;
        public IEnumerable<Category> Categories { get; set; }

        public IndexModel(ApplicationDbContext db)
        {
            _db=db;
        }
        public void OnGet()
        {
            // all category records
            Categories = _db.Category;
        }
    }
}
