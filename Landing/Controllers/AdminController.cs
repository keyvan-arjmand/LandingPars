using Dal.Entity;
using Dal.Repo;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Landing.Controllers;

public class AdminController : Controller
{    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IUnitOfWork _work;

    public AdminController(IUnitOfWork work, IWebHostEnvironment webHostEnvironment, RoleManager<Role> roleManager, SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _work = work;
        _webHostEnvironment = webHostEnvironment;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _userManager = userManager;
    }

    // GET
    public async Task<ActionResult> Index()
    {
        if (User.Identity.IsAuthenticated)
        {
            #region ViewBag
            ViewBag.Users = await _userManager.Users.Take(12).OrderByDescending(x => x.InsertDate).ToListAsync();
            #endregion
          return View();
        }
        else
        {
            return View("Login");
        }
    }
}