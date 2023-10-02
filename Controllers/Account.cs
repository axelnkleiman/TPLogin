using Microsoft.AspNetCore.Mvc;

namespace Tp Login.Controllers;

public class Account : Controller
{
    /*
    public IActionResult Index()
    {
        return View();
    }
    */
    public IActionResult Login()
    {
        return View();
    }
    public IActionResult Registro(){
        return View();
    }
    public IActionResult GuardarDatos(string username, string contrasena, string mail, string respuesta, DateTime fechanacimiento){
        User.Username = useraname;
        User.Contrasena = contrasena;
        User.Mail = mail;
        User.Respuesta = respuesta;
        User.FechaNacimiento = fechanacimiento;
        return View();
    }
    public IActionResult VerificarDatos(string username, string contrasena){
        if (datos)
        {
            return View("Bienvenida");
        }
        else
        {
            ViewBag.MensajeError = "Datos incorrectos, vuelva a intentar"
            return View("Login")
        }
    }
    public IActionResult OlvideMiContraseña(){
        return View();
    }
    public IActionResult Bienvenida(){
        return View();
    }
}
