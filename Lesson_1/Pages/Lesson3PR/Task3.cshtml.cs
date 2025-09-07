using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson3PR
{
    public class Task3Model : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "Email �����������")]
        [EmailAddress(ErrorMessage = "������� ������ email")]
        public string Email { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["SuccessMessage"] = $"�� ������ ���������� �� ������: {Email}";
            return RedirectToPage("Success");
        }
    }
}
