using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson2
{
    public class Task4Model : PageModel
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public int? Page { get; set; }

        public void OnGet(int id, string color, int? page)
        {
            Id = id;
            Color = color;
            Page = page ?? 1;
        }
    }
}
