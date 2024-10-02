using Dal.Entity;
using Dal.Repo;
using Landing.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Landing.Controllers;

public class AdminController : Controller
{
    private readonly UserManager<User> _userManager;
    private readonly SignInManager<User> _signInManager;
    private readonly RoleManager<Role> _roleManager;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private readonly IUnitOfWork _work;


    public AdminController(IUnitOfWork work, IWebHostEnvironment webHostEnvironment, RoleManager<Role> roleManager,
        SignInManager<User> signInManager, UserManager<User> userManager)
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
            ViewBag.Brands = await _work.GenericRepository<Brand>().TableNoTracking.Take(10).ToListAsync();
            ViewBag.subPage = await _work.GenericRepository<SubPage>().TableNoTracking.CountAsync();

            #endregion

            return View();
        }
        else
        {
            return View("Login");
        }
    }

    public async Task<ActionResult> ManageLanding()
    {
        if (User.Identity.IsAuthenticated)
        {
            #region ViewBag

            ViewBag.Landing = await _work.GenericRepository<LandingPage>().TableNoTracking.FirstOrDefaultAsync();

            #endregion

            return View();
        }
        else
        {
            return View("Login");
        }
    }

    public async Task<ActionResult> GoToLoginWithPassword()
    {
        return View("LoginPassword");
    }

    public async Task<ActionResult> Login()
    {
        return View();
    }

    public async Task<ActionResult> Brand()
    {
        ViewBag.Category = await _work.GenericRepository<Brand>().TableNoTracking.ToListAsync();
        return View();
    }

    public async Task<ActionResult> SubPage()
    {
        ViewBag.SubPages =
            await _work.GenericRepository<SubPage>().TableNoTracking.Include(x => x.Category).ToListAsync();
        return View();
    }

    public async Task<ActionResult> SubPageDetail(int id)
    {
        ViewBag.SubPage =
            await _work.GenericRepository<SubPage>().TableNoTracking.FirstOrDefaultAsync(x => x.Id == id);
        return View();
    }

    public async Task initAdmin2()
    {
        var user = new User
        {
            Family = "k1",
            Name = "ارجمند",
            PhoneNumber = "09211129482",
            Email = "",
            Password = "1111",
            InsertDate = DateTime.Now,
            UserName = "09211129482",
            SecurityStamp = string.Empty,
        };
        if (!await _roleManager.RoleExistsAsync("user"))
        {
            await _roleManager.CreateAsync(new Role
            {
                Name = "user"
            });
        }

        if (!await _roleManager.RoleExistsAsync("admin"))
        {
            await _roleManager.CreateAsync(new Role
            {
                Name = "admin"
            });
        }

        await _userManager.CreateAsync(user, "1111");
        await _userManager.AddToRoleAsync(user, "user");
        await _userManager.AddToRoleAsync(user, "admin");
        await _userManager.UpdateAsync(user);
    }

    public async Task<ActionResult> CheckPhoneNumber(string phoneNumber)
    {
        var user = await _userManager.FindByNameAsync(phoneNumber);
        var userRoles = await _userManager.GetRolesAsync(user);
        if (user == null && userRoles.Any(x => !x.Equals("admin")))
            throw new Exception("User not Exist");
        return Ok();
    }

    public async Task<IActionResult> Logout()
    {
        if (User.Identity.IsAuthenticated)
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        else return RedirectToAction("Index", "Home");
    }

    public async Task<ActionResult> ConfirmPassword(string password, string phoneNumber)
    {
        var user = await _userManager.FindByNameAsync(phoneNumber);
        var userRoles = await _userManager.GetRolesAsync(user);
        if (user == null && userRoles.Any(x => !x.Equals("admin")))
            throw new Exception("User not Exist");
        var result = await _signInManager.PasswordSignInAsync(user, password, true, false);
        if (!result.Succeeded)
            throw new Exception("invalid password");
        return Ok();
    }

    public async Task<ActionResult> LoginPassword(string phoneNumber)
    {
        var user = await _userManager.FindByNameAsync(phoneNumber);
        var userRoles = await _userManager.GetRolesAsync(user);
        if (user == null && userRoles.Any(x => !x.Equals("admin")))
            throw new Exception("User not Exist");
        ViewBag.exUser = new UserLoginDto
        {
            Family = user.Family,
            PhoneNumber = user.PhoneNumber,
            Name = user.Name,
            Id = user.Id,
        };
        return View("LoginPassword");
    }

    public async Task<ActionResult> LoginAPassword(string phoneNumber)
    {
        var user = await _userManager.FindByNameAsync(phoneNumber);
        var userRoles = await _userManager.GetRolesAsync(user);
        if (user == null && userRoles.Any(x => !x.Equals("admin")))
            throw new Exception("User not Exist");

        return Ok();
    }

    public async Task<ActionResult> InsertBrand(string title, IFormFile logo)
    {
        Upload up = new Upload(_webHostEnvironment);
        string img = up.Uploadfile(logo, "brand");
        await _work.GenericRepository<Brand>().AddAsync(new Brand
        {
            Title = title,
            Logo = img
        }, CancellationToken.None);
        return RedirectToAction("Brand");
    }

    public async Task<ActionResult> UpdateSubPage(SubPage request)
    {
        var subPage = await _work.GenericRepository<SubPage>().Table.FirstOrDefaultAsync(x => x.Id == request.Id);
        subPage.Desc = request.Desc;
        subPage.DescEn = request.DescEn;
        subPage.SeoTitle = request.SeoTitle;
        subPage.SeoCanonical = request.SeoCanonical;
        subPage.SeoDesc = request.SeoDesc;

        await _work.GenericRepository<SubPage>().UpdateAsync(subPage, CancellationToken.None);
        return RedirectToAction("SubPage");
    }

    public async Task<ActionResult> UpdateLanding(LandingDto request)
    {
        var subPage = await _work.GenericRepository<LandingPage>().Table.FirstOrDefaultAsync(x => x.Id == request.id);

        subPage.SeoIndexTitle = request.SeoIndexTitle;
        subPage.SeoIndexDesc = request.SeoIndexDesc;
        subPage.SeoIndexCanonical = request.SeoIndexCanonical;

        Upload up = new Upload(_webHostEnvironment);

        subPage.ImageSlider = request.ImageSlider != null
            ? up.Uploadfile(request.ImageSlider, "landing")
            : subPage.ImageSlider;
        subPage.ImageSlider2 = request.ImageSlider2 != null
            ? up.Uploadfile(request.ImageSlider2, "landing")
            : subPage.ImageSlider2;
        subPage.ImageSlider3 =  request.ImageSlider3 != null
            ? up.Uploadfile(request.ImageSlider3, "landing")
            : subPage.ImageSlider3;
        subPage.ImageSlider4 =  request.ImageSlider4 != null
            ? up.Uploadfile(request.ImageSlider4, "landing")
            : subPage.ImageSlider4;
        subPage.ImageSlider5 =  request.ImageSlider5 != null
            ? up.Uploadfile(request.ImageSlider5, "landing")
            : subPage.ImageSlider5;

        subPage.TitleSlider = request.TitleSlider;
        subPage.TitleSlider2 = request.TitleSlider2;
        subPage.TitleSlider3 = request.TitleSlider3;
        subPage.TitleSlider4 = request.TitleSlider4;
        subPage.TitleSlider5 = request.TitleSlider5;

        subPage.SubTitleSlider = request.SubTitleSlider;
        subPage.SubTitleSlider2 = request.SubTitleSlider2;
        subPage.SubTitleSlider3 = request.SubTitleSlider3;
        subPage.SubTitleSlider4 = request.SubTitleSlider4;
        subPage.SubTitleSlider5 = request.SubTitleSlider5;

        subPage.TitleSliderEn = request.TitleSliderEn;
        subPage.TitleSliderEn2 = request.TitleSliderEn2;
        subPage.TitleSliderEn3 = request.TitleSliderEn3;
        subPage.TitleSliderEn4 = request.TitleSliderEn4;
        subPage.TitleSliderEn5 = request.TitleSliderEn5;


        subPage.SubTitleSliderEn = request.SubTitleSliderEn;
        subPage.SubTitleSliderEn2 = request.SubTitleSliderEn2;
        subPage.SubTitleSliderEn3 = request.SubTitleSliderEn3;
        subPage.SubTitleSliderEn4 = request.SubTitleSliderEn4;
        subPage.SubTitleSliderEn5 = request.SubTitleSliderEn5;


        await _work.GenericRepository<LandingPage>().UpdateAsync(subPage, CancellationToken.None);
        return RedirectToAction("ManageLanding");
    }

    [HttpPost]
    [EnableCors("AllowSpecificOrigin")]
    public IActionResult UploadImage(IFormFile upload)
    {
        // Response.Headers.Add("Access-Control-Allow-Origin", "http://newdev.parsme.com");
        Response.Headers.Add("Access-Control-Allow-Methods", "POST, GET, OPTIONS");
        Response.Headers.Add("Access-Control-Allow-Headers", "Content-Type");
        if (upload != null && upload.Length > 0)
        {
            try
            {
                Upload up = new Upload(_webHostEnvironment);
                var name = up.Uploadfile(upload, "editor");
                // Return the URL to the uploaded file.
                var fileUrl = $"/images/editor/{name}";
                return Json(new { uploaded = true, url = fileUrl });
            }
            catch (Exception ex)
            {
                return Json(new { uploaded = false, error = ex.Message });
            }
        }

        return Json(new { uploaded = false, error = "No file was uploaded." });
    }

    public async Task<ActionResult> DeleteBrand(int Id)
    {
        var brand = await _work.GenericRepository<Brand>().Table.FirstOrDefaultAsync(x => x.Id == Id);
        await _work.GenericRepository<Brand>().DeleteAsync(brand, CancellationToken.None);
        return RedirectToAction("Brand");
    }

    public async Task<IActionResult> InsertAdmin(InsertUser request)
    {
        var user = new User
        {
            Family = request.Family,
            Name = request.Name,
            PhoneNumber = request.PhoneNumber,
            Email = request.Email,
            Password = request.Password,
            InsertDate = DateTime.Now,
            UserName = request.PhoneNumber,
            SecurityStamp = string.Empty,
        };
        if (!await _roleManager.RoleExistsAsync("user"))
        {
            await _roleManager.CreateAsync(new Role
            {
                Name = "user"
            });
        }

        await _userManager.CreateAsync(user, request.Password);
        foreach (var r in request.Role)
        {
            await _userManager.AddToRoleAsync(user, r);
        }

        await _userManager.AddToRoleAsync(user, "user");
        await _userManager.UpdateAsync(user);
        return RedirectToAction("ManageUser");
    }

    public async Task<IActionResult> UpdateAdmin(UpdateUser request)
    {
        var user = await _userManager.Users.FirstOrDefaultAsync(x =>
            x.UserName == request.PhoneNumber && x.PhoneNumber == request.PhoneNumber);
        Upload up = new Upload(_webHostEnvironment);
        user.Name = request.Name;
        user.Family = request.Family;
        if (request.Password != user.Password)
        {
            await _userManager.ChangePasswordAsync(user, user.Password, request.Password);
            user.Password = request.Password;
        }

        foreach (var r in request.Role)
        {
            await _userManager.AddToRoleAsync(user, r);
        }

        await _userManager.UpdateAsync(user);
        return RedirectToAction("ManageUser");
    }

    public class InsertUser
    {
        public string Name { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<string> Role { get; set; }
        public string Password { get; set; } = string.Empty;
    }

    public class UpdateUser
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<string> Role { get; set; }
        public string Password { get; set; } = string.Empty;
    }

    public class UserDto
    {
        public string Name { get; set; } = string.Empty;
        public string Family { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime InsertDate { get; set; } = DateTime.Now;
        public List<string> Roles { get; set; } = default!;
    }

    public async Task<ActionResult> ManageUser(string search)
    {
        if (User.Identity.IsAuthenticated)
        {
            if (string.IsNullOrEmpty(search))
            {
                var user = await _userManager.Users.OrderByDescending(x => x.Id).ToListAsync();
                var users = new List<UserDto>();
                foreach (var i in user)
                {
                    var a = await _userManager.GetRolesAsync(i);
                    users.Add(new UserDto
                    {
                        Family = i.Family,
                        Name = i.Name,
                        Password = i.Password,
                        InsertDate = i.InsertDate,
                        PhoneNumber = i.PhoneNumber,
                        Email = i.Email ?? string.Empty,
                        Roles = a.ToList(),
                    });
                }

                ViewBag.Users = users;
                ViewBag.Roles = await _roleManager.Roles.ToListAsync();
            }
            else
            {
                var user = await _userManager.Users.Where(x =>
                        x.UserName.Contains(search) || x.Name.Contains(search) || x.Family.Contains(search)
                        || x.Email.Contains(search) ||
                        x.PhoneNumber.Contains(search)).OrderByDescending(x => x.Id)
                    .ToListAsync();
                var users = new List<UserDto>();
                foreach (var i in user)
                {
                    var a = await _userManager.GetRolesAsync(i);
                    users.Add(new UserDto
                    {
                        Family = i.Family,
                        Name = i.Name,
                        Password = i.Password,
                        InsertDate = i.InsertDate,
                        PhoneNumber = i.PhoneNumber,
                        Email = i.Email ?? string.Empty,
                        Roles = a.ToList()
                    });
                }

                ViewBag.Users = users;
                ViewBag.Roles = await _roleManager.Roles.OrderByDescending(x => x.Id).ToListAsync();
            }

            return View();
        }
        else
        {
            return View("Index");
        }
    }
}