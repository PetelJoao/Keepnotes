using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using Microsoft.AspNetCore.Mvc;
using NoteApp.Models;
using System.Text.Json;
using System.IO;


namespace NoteApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        List<NOTA> NotasSalvas = new List<NOTA>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

       



        public IActionResult Index()
        {
           

      
                 
            return View();
        }


  
        public IActionResult AddNota(string Nota , string NotaDesc )
        {
            
            ViewData["TituloNota"] = Nota;
            ViewData["DescricaoNota"] = NotaDesc;
            return View();
        }


        public IActionResult ExcluirNota(string Notaex="~")
        {

            ViewData["TNota"] = Notaex;
        
            return View();
        }

        public IActionResult NotasEscluidas()
        {

          

            return View();
        }
      


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
