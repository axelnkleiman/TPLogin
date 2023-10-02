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
    public IActionResult GuardarDatos(User usuario){
        BD.AgregarUsuario(usuario)
        return View("Login");
    }
    public IActionResult VerificarDatos(string username, string contrasena){
        User datos = null;
        datos = BD.VerInfoUsuario(username);
        if (datos.Username==username && datos.Contrasena==contrasena)
        {
            return View("Bienvenida");
        }
        else
        {
            ViewBag.MensajeError = "Datos incorrectos, vuelva a intentar";
            return View("Login");
        }
    }
    public IActionResult OlvideMiContrasena(){
        return View();
    }
    //el form le manda el mail, la respuesta, y la nueva contraseña
    public IActionResult CambiarContrasena(){
        //pedir un bool del BD y que si este mal te salte error general
    }
    public IActionResult Bienvenida(){
        return View();
    }
}
