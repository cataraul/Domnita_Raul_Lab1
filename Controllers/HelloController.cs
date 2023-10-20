using Microsoft.AspNetCore.Mvc;

namespace Domnita_Raul_Lab1.Controllers
{
    public class HelloController : Controller
    {
        public string Index()
        {
            return "Welcome!";
        }

        public string HelloThere()
        {
            return "Hello there, dear colleague!";
        }

        public string HowOld(string name, int age)
        {
            return $"So, {name}, you are {age} years old. Nice.";
        }
    }
}
