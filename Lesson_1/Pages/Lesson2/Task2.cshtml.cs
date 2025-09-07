using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson2
{
    public class Task2Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "Це повідомлення з ViewData";

            ViewData["world"] = "А це повідомлення з ViewBag";
        }
    }
}
