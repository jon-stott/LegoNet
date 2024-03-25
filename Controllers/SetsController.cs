using LegoNet.Models;
using LegoNet.Services;
using Microsoft.AspNetCore.Mvc;

namespace LegoNet.Controllers;

public class SetsController : Controller
{

    private readonly ISetService _setService;

    public SetsController(ISetService setService)
    {
        _setService = setService;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        Task<List<Set>> setsTask = _setService.GetAllAsync();
        List<Set> sets = await setsTask;
        // colours.Sort();
        return View(sets);
    }

}