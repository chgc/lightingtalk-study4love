﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using server.Models;

namespace server.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }

    public class ScriptHTMLViewComponent : ViewComponent
    {
        private IHostingEnvironment _env;

        public ScriptHTMLViewComponent(IHostingEnvironment env)
        {
            _env = env;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {

            var model = System.IO.File.ReadAllText(Path.Combine(_env.WebRootPath, "script.html"));
            return View("Index", model);
        }
    }
}
