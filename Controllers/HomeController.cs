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
}
