using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson1
{
    
    public class Task2Model : PageModel
    {
        public int RandomNumber { get; set; }
        public void OnGet()
        {
            Random rnd = new Random();
            RandomNumber = rnd.Next(1,101);
        }
    }
}
