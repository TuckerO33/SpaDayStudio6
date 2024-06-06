using System.ComponentModel;
using Microsoft.AspNetCore.Mvc;
using SpaDay6.Models;
namespace SpaDay6.Controllers;

[Route ("/user")]
public class UserController : Controller
{
    [HttpGet]
    [Route("add")]
        public IActionResult Add()
    {
        return View();
    }

       public IActionResult SubmitAddUserForm(User newUser, string verify)
    {
        User nUser = new User();
        return View();
    }
}