using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace Exercicio06.Controllers;

public class Exercicio06 : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Saudacao01(string name)
    {
        ViewData["mensagem"] = ($"{name}, seja bem vindo(a) IFSP.");
        return View();
    }

    public IActionResult Saudacao02(string name, int numAtiv)
    {
        ViewData["mensagem"] = ($"Ola {name}, voce devera desenvolver {numAtiv} atividades ao longo do semestre.");
        return View();
    }

    public IActionResult Saudacao03(string name, string periodo)
    {
        if(periodo == "Matutino"){
            ViewData["mensagem"] = ($"SEDCITEC - 18 a 22 de Setembro - Ola {name}, como voce esta no periodo {periodo}, devera participar da SEDCITEC no periodo das 07h:00m as 11h:45m.");
        }

        else if(periodo == "Vespertino"){
            ViewData["mensagem"] = ($"SEDCITEC - 18 a 22 de Setembro - Ola {name}, como voce esta no periodo {periodo}, devera participar da SEDCITEC no periodo das 13h:15m as 18h:00m.");
            }

        else {
            ViewData["mensagem"] = ("Periodo Invalido");
        }
        return View();
    }
}