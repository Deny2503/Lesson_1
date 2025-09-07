using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson3PR
{
    public class Task2Model : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Ім’я обов’язкове")]
        [StringLength(100, ErrorMessage = "Ім’я не може бути довше 100 символів")]
        public string FullName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email обов’язковий")]
        [EmailAddress(ErrorMessage = "Невірний формат email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Повідомлення обов’язкове")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "Повідомлення має містити від 10 символів")]
        public string Message { get; set; }

        public static List<(string FullName, string Email, string Message)> Messages
            = new List<(string, string, string)>();

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Messages.Add((FullName, Email, Message));

            return RedirectToPage("ThankYou");
        }
    }
}
