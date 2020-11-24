using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace photo.Controllers
{
    [Route("login")]
    public class UserController : ControllerBase
    {
        
        public ActionResult<string> Index()
        {
            return "ss";
        }
        [HttpGet("auth")]
        public ActionResult<string> Authenticate()
        {
            var claim = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, "Bob"),
                new Claim(ClaimTypes.Email, "Bsb@dgkspp.com"),
                new Claim("Says", "good")
            };

            var identity = new ClaimsIdentity(claim, "identity");
            var userPrincipal = new ClaimsPrincipal(identity);
            HttpContext.SignInAsync(userPrincipal);
            return RedirectToAction("Index");
    }
}
}
