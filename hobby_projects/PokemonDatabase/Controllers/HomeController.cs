// Imports 
using Microsoft.AspNetCore.Mvc;
//this file exists here
namespace PokemonDatabase.Controllers;

public class HomeController : Controller
{
    // Basic get call to server
    public IActionResult Index()
    {
        return View();
    }
}

