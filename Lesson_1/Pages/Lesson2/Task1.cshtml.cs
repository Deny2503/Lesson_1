using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson2
{
    public class Task1Model : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "Привіт, студент!";
        }
    }
}
