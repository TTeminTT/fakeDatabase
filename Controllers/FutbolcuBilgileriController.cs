

using Microsoft.AspNetCore.Mvc;
using MVCSinav.Models;

namespace MVCSinav.Controllers
{
    public class FutbolcuBilgileriController : Controller
    {
        public IActionResult Index(){
           Futbolcu futbolcu = new Futbolcu(){
            AdiSoyadi=" Messi",
            Ulkesi="Arjantin",
            OynadigiTakim="Paris Saint-Germain",
            FormaNumarasi=10,
            PiyasaDegeri=45000000,
            Gorseller="~/img/gorsel1.jpg"
           };
           return View(futbolcu);
        }
    }
}