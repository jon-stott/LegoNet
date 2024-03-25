using LegoNet.Models;
using LegoNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoNet.Controllers;

public class ColoursController : Controller
{

    private readonly IColourService _colourService;

    public ColoursController(IColourService colourService)
    {
        _colourService = colourService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        Task<List<Colour>> coloursTask = _colourService.GetAllAsync();
        List<Colour> colours = await coloursTask;
        colours.Sort();
        return View(colours);
    }

}