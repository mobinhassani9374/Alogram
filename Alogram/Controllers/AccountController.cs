using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Alogram.Controllers
{
    public class AccountController : Controller
    {
        [AllowAnonymous]
        [HttpPost]
        [Route("/login")]
        public IActionResult Login(string phoneNumber)
        {
            return Ok();
        }
    }
}