using Microsoft.AspNetCore.Mvc;
namespace RazorDivertido.Controllers;

public class PrincipalController : Controller{
  [HttpGet("")]
  public ViewResult Index(){
    return View();
  }
}