using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson3PR
{
    public class Task1Model : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Ім’я обов’язкове")]
        [StringLength(50, ErrorMessage = "Ім’я не може бути довше 50 символів")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email обов’язковий")]
        [EmailAddress(ErrorMessage = "Невірний формат email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Пароль обов’язковий")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Пароль має бути мінімум 6 символів")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Підтвердження пароля обов’язкове")]
        [Compare("Password", ErrorMessage = "Паролі не співпадають")]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        [Range(18, 100, ErrorMessage = "Вік має бути від 18 до 100 років")]
        public int Age { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["SuccessMessage"] = "Реєстрація пройшла успішно!";

            return RedirectToPage("Success");
        }
    }
}
