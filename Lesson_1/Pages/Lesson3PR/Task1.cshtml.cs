using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson3PR
{
    public class Task1Model : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "��� ����������")]
        [StringLength(50, ErrorMessage = "��� �� ���� ���� ����� 50 �������")]
        public string Name { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email �����������")]
        [EmailAddress(ErrorMessage = "������� ������ email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "������ �����������")]
        [StringLength(100, MinimumLength = 6, ErrorMessage = "������ �� ���� ����� 6 �������")]
        public string Password { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "ϳ����������� ������ ����������")]
        [Compare("Password", ErrorMessage = "����� �� ����������")]
        public string ConfirmPassword { get; set; }

        [BindProperty]
        [Range(18, 100, ErrorMessage = "³� �� ���� �� 18 �� 100 ����")]
        public int Age { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            TempData["SuccessMessage"] = "��������� ������� ������!";

            return RedirectToPage("Success");
        }
    }
}
