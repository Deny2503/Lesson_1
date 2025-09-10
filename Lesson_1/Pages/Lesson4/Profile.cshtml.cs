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
                Name = "Олег",
                Email = "oleg@example.com",
                AvatarUrl = "oleg.jpg"
            };

            TempData["Notifications"] = new List<(string, string)>
            {
                ("success", "Ваш профіль успішно оновлено!"),
                ("warning", "Пароль закінчується через 5 днів."),
                ("error", "Не вдалося завантажити аватар.")
            };
        }
    }
}
