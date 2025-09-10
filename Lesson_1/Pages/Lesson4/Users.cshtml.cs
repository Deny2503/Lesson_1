using Lesson_1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson4
{
    public class UsersModel : PageModel
    {
        public List<User> Users { get; set; }

        public void OnGet()
        {
            Users = new List<User>
            {
                new User { Name = "Іван", Email = "ivan@example.com", AvatarUrl = "ivan.jpg" },
                new User { Name = "Марія", Email = "maria@example.com", AvatarUrl = "maria.jpg" }
            };
        }
    }
}
