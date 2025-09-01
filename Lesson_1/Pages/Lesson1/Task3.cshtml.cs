using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson1
{
    public class Task3Model : PageModel
    {
        [BindProperty]
        public double Celsius { get; set; }
        public double? Fahrenheit { get; set; }
        public void OnPost()
        {
            Fahrenheit = Celsius * 9 / 5 + 32;
        }
    }
}
