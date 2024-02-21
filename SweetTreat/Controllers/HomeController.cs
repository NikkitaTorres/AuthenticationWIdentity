using Microsoft.AspNetCore.Mvc;
using SweetTreat.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace SweetTreat.Controllers
{
    public class HomeController : Controller
    {
      private readonly SweetTreatContext _db;
      private readonly UserManager<ApplicationUser> _userManager;

      public HomeController(UserManager<ApplicationUser> userManager, SweetTreatContext db)
      {
        _userManager = userManager;
        _db = db;
      }

      [HttpGet("/")]
      public async Task<ActionResult> Index()
      {
        Flavor[] flavors = _db.Flavors.ToArray();
        Treat[] treats = _db.Treats.ToArray();
        Dictionary<string,object[]> model = new Dictionary<string, object[]>();
        model.Add("flavors", flavors);
        model.Add("treats", treats);
        string userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        ApplicationUser currentUser = await _userManager.FindByIdAsync(userId);
        return View(model);
      }
    }
}