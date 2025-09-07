using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages
{
    public class SearchModel : PageModel
    {
        public int Num { get; set; }
        public void OnGet(int num = 1)
        {
            Num = num;
        }
    }
}
