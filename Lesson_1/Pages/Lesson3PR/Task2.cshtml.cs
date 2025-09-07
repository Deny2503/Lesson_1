using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson3PR
{
    public class Task2Model : PageModel
    {
        [BindProperty]
        [Required(ErrorMessage = "��� ����������")]
        [StringLength(100, ErrorMessage = "��� �� ���� ���� ����� 100 �������")]
        public string FullName { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "Email �����������")]
        [EmailAddress(ErrorMessage = "������� ������ email")]
        public string Email { get; set; }

        [BindProperty]
        [Required(ErrorMessage = "����������� ����������")]
        [StringLength(1000, MinimumLength = 10, ErrorMessage = "����������� �� ������ �� 10 �������")]
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
