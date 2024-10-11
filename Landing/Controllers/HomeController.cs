using System.Diagnostics;
using Dal.Entity;
using Dal.Repo;
using Microsoft.AspNetCore.Mvc;
using Landing.Models;
using Microsoft.EntityFrameworkCore;

namespace Landing.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IUnitOfWork _work;

    public HomeController(ILogger<HomeController> logger, IUnitOfWork work)
    {
        _logger = logger;
        _work = work;
    }

    public async Task<IActionResult> Index()
    {
        ViewBag.Cats = await _work.GenericRepository<Category>().TableNoTracking.Include(x => x.Pages).ToListAsync();
        ViewBag.Brand = await _work.GenericRepository<Brand>().TableNoTracking.ToListAsync();
        ViewBag.Landing = await _work.GenericRepository<LandingPage>().TableNoTracking.FirstOrDefaultAsync();
        return View();
    }

    public async Task<IActionResult> ContactUs()
    {
        ViewBag.Cats = await _work.GenericRepository<Category>().TableNoTracking.Include(x => x.Pages).ToListAsync();
        var page = await _work.GenericRepository<SubPage>().TableNoTracking
            .FirstOrDefaultAsync(x => x.Title.Contains("تماس با ما"));
        ViewBag.Page = page;
        ViewBag.Landing = await _work.GenericRepository<LandingPage>().TableNoTracking.FirstOrDefaultAsync();

        return View();
    }

    public async Task<IActionResult> CooperateWithUs()
    {
        ViewBag.Cats = await _work.GenericRepository<Category>().TableNoTracking.Include(x => x.Pages).ToListAsync();
        var page = await _work.GenericRepository<SubPage>().TableNoTracking
            .FirstOrDefaultAsync(x => x.Title.Contains("تماس با ما"));
        ViewBag.Page = page;
        ViewBag.Landing = await _work.GenericRepository<LandingPage>().TableNoTracking.FirstOrDefaultAsync();

        return View();
    }

    public async Task<IActionResult> Collaboration()
    {
        ViewBag.Cats = await _work.GenericRepository<Category>().TableNoTracking.Include(x => x.Pages).ToListAsync();
        var page = await _work.GenericRepository<SubPage>().TableNoTracking
            .FirstOrDefaultAsync(x => x.Title.Contains("درخواست همکاری"));
        ViewBag.Page = page;
        ViewBag.Landing = await _work.GenericRepository<LandingPage>().TableNoTracking.FirstOrDefaultAsync();
        return View();
    }

    public async Task<IActionResult> SendMessage(string name, string number, string email, string desc)
    {
        await _work.GenericRepository<Message>().AddAsync(new Message
        {
            Name = name,
            Email = email,
            Desc = desc,
            Number = number,
            InsertDate = DateTime.Now
        }, CancellationToken.None);
        var previousUrl = Request.Headers["Referer"];
        if (!string.IsNullOrEmpty(previousUrl))
        {
            return Redirect(previousUrl);
        }
        else
        {
            return RedirectToAction("Index", "Home");
        }
    }

    public async Task<IActionResult> Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}