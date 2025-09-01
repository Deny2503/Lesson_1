using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson1
{
    public class CurrentTimeModel : PageModel
    {
        public DateTime CurrentDateTime { get; set; }
        public void OnGet()
        {
            CurrentDateTime = DateTime.Now;
        }
    }
}
