using Microsoft.AspNetCore.Mvc;

namespace WebMVCR1.Controllers
{
    public class HomeController : Controller
    {
        public string Index(string hel)
        {
            int hour = DateTime.Now.Hour;
            string Greeting = hour < 12 ? "Доброе утро" : "Добрый день";

            // Добавляем параметр к приветствию, если он был передан
            if (!string.IsNullOrEmpty(hel))
            {
                Greeting += ", " + hel;
            }

            return Greeting;
        }
    }
}