using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages
{
    public class HelloModel : PageModel
    {
        [BindProperty]
        public string UserName { get; set; } = "";
        public string Message { get; set; } = "";
        public string CurrentTime { get; set; } = "";

        public void OnGet()
        {
            CurrentTime = DateTime.Now.ToLongTimeString();
        }

        public void OnPost()
        {
            if (!string.IsNullOrEmpty(UserName))
            {
                Message = $"Hello, {UserName}! Welcome! ";
            }
            else
            {
                Message = "Enter your name!!!!";
            }
        }
    }
}
