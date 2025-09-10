using Lesson_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson4
{
    public class ProfileModel : PageModel
    {
        public User CurrentUser { get; set; }

        public void OnGet()
        {
            CurrentUser = new User
            {
                Name = "����",
                Email = "oleg@example.com",
                AvatarUrl = "oleg.jpg"
            };

            TempData["Notifications"] = new List<(string, string)>
            {
                ("success", "��� ������� ������ ��������!"),
                ("warning", "������ ���������� ����� 5 ���."),
                ("error", "�� ������� ����������� ������.")
            };
        }
    }
}
