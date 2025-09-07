using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages
{
    public class InfoModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }
        public string Message { get; set; }
        public void OnGet()
        {
            ViewData["hello"] = "First message";
            ViewData["world"] = "World";
        }
        public void OnPost()
        {
            Message = $"Hello, {Name}";
        }
    }
}
