using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson2
{
    public class Task2Model : PageModel
    {
        public void OnGet()
        {
            ViewData["Message"] = "�� ����������� � ViewData";

            ViewData["world"] = "� �� ����������� � ViewBag";
        }
    }
}
