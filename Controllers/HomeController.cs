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
            Paquete nuevo = new Paquete(ORTWorld.ListaHoteles[Hotel-1],ORTWorld.ListaAereos[Aereo-1], ORTWorld.ListaExcursiones[Excursion-1]);
            ORTWorld.IngresarPaquete(ORTWorld.ListaDestinos[Destino-1], nuevo);
            return RedirectToAction("Index");    
    }
}
