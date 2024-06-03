using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using TP04_Minuchin_Dominguez.Models;

namespace TP04_Minuchin_Dominguez.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
         ViewBag.DicPaquetes = ORTWorld.Paquetes;
        return View();
    }

    public IActionResult SelectPaquete()
    {
        ViewBag.Hoteles = ORTWorld.ListaHoteles;
        ViewBag.Excursiones = ORTWorld.ListaExcursiones;
        ViewBag.Aereos = ORTWorld.ListaAereos;
        ViewBag.Destinos= ORTWorld.ListaDestinos;
        return View();
    }

    public IActionResult GuardarPaquete(int Destino, int Hotel, int Aereo, int Excursion)
    {
        if(Destino > 10 || Destino < 1 || Hotel > 10 || Hotel < 1 || Aereo > 10 || Aereo < 1 || Excursion > 10 || Excursion < 1)
        {
            ViewBag.MsjError = "Error";
            return View (SelectPaquete);
        }
        else
        {
            Paquete nuevo = new Paquete(ORTWorld.ListaHoteles[Hotel-1],ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursion-1]);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], nuevo);
            RedirectToAction("Index");
            return View(Index);
        }
        
    }
}
