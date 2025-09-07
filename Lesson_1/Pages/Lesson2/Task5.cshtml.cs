using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson2
{
    public class Task5Model : PageModel
    {
        [BindProperty]
        public string Comment { get; set; }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(Comment))
            {
                ViewData["Comment"] = Comment;
            }
        }
    }
}
