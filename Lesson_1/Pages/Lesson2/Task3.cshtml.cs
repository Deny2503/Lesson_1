using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson2
{
    public class Task3Model : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        public string Greeting { get; set; }

        public void OnPost()
        {
            if (!string.IsNullOrWhiteSpace(Name))
            {
                Greeting = $"Привіт, {Name}!";
            }
        }
    }
}
