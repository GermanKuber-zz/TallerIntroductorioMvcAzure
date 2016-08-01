using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public string Index()
        {
            return "Hola mundo desde el Index";
        }
        public string Welcome()
        {
            return "Hola mundo desde la página de Welcome";
        }
        ///HelloWorld/WelcomeUser?user=
        public string WelcomeUser(string user)
        {
            return $"Bienvenido {user} a la pagina de Welcome";
        }
        /////HelloWorld/WelcomeUser?user=
        public string WelcomeData(string name, int id)
        {
            return $"Bienvenido {name} a la pagina de Welcome";
        }
    }
}