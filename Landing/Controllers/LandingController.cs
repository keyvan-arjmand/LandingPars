using Dal.Entity;
using Dal.Repo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Landing.Controllers;

public class LandingController : Controller
{
    private readonly IUnitOfWork _work;

    public LandingController(IUnitOfWork work)
    {
        _work = work;
    }

    // GET
    public async Task<IActionResult> Index(string q)
    {
        var page = await _work.GenericRepository<SubPage>().TableNoTracking.FirstOrDefaultAsync(x => x.Title.Contains(q)||x.TitleEn.Contains(q));
        ViewBag.Page = page;
        ViewBag.Landing = await _work.GenericRepository<LandingPage>().TableNoTracking.FirstOrDefaultAsync();
        ViewBag.Cats = await _work.GenericRepository<Category>().TableNoTracking.Include(x => x.Pages).ToListAsync();
        return View();
    }
}