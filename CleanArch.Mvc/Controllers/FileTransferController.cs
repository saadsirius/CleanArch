﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{
    public class FileTransferController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}