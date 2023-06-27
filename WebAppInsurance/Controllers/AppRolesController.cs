using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace WebAppInsurance.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AppRolesController : Controller
    {
        private readonly RoleManager<IdentityRole> _roleManager;

        public AppRolesController(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        
        // Seznam všech rolí pro uživatele
        public IActionResult Index()
        {
            var roles = _roleManager.Roles;
            return View(roles);
        }
        
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        
        public async Task<IActionResult> Create(IdentityRole model)
        {
            // vyhnutí duplikace role
            if (!await _roleManager.RoleExistsAsync(model.Name))
            {
                await _roleManager.CreateAsync(new IdentityRole(model.Name));
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(string roleName)
        {
            var role = await _roleManager.FindByIdAsync(roleName);
            if (role != null)
            {
                await _roleManager.DeleteAsync(role);
            }
            return RedirectToAction("Index");
        }
    }
}
