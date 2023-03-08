using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;
public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public string Welcome(string name, int ID = 1)
    {
        //return "This is the welcome action method....";
        return HtmlEncoder.Default.Encode($"Helloe {name}, Your ID is {ID}");
    }
}