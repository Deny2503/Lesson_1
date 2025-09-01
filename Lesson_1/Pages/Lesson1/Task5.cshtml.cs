using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson1
{
    public class Task5Model : PageModel
    {
        public class ContactForm
        {
            public string Name { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
            public string Message { get; set; } = string.Empty;
        }

        [BindProperty]
        public ContactForm Contact { get; set; } = new ContactForm();
        public bool isSubmitted { get; set; } = false;
        public void OnPost()
        {
            isSubmitted = true;
        }
    }
}
