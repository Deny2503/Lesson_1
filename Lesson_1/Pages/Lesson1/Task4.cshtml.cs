using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lesson_1.Pages.Lesson1
{
    public class Task4Model : PageModel
    {
        private static readonly string[] Quotes =
        {
            "Секрет успіху — це почати.",
            "Вчитися ніколи не пізно.",
            "Кожна помилка — це крок до перемоги.",
            "Сьогодні — найкращий день, щоб почати.",
            "Мрій масштабно, працюй наполегливо.",
            "Знання — це сила.",
            "Наполегливість перемагає талант."
        };
        public string SelectedQuote { get; set; } = string.Empty;
        public void OnGet()
        {
            var rnd = new Random();
            int index = rnd.Next(Quotes.Length);
            SelectedQuote = Quotes[index];
        }
    }
}
