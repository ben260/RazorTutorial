using System.ComponentModel.DataAnnotations;

namespace RazorTutorialWeb.Model
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public  string  Name { get; set; }
        [Display(Name="Display Order")]
        [Range(1,100,ErrorMessage="Invalid range bro")]
        public int DisplayOrder { get; set; }

    }
}
