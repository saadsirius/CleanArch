using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.Controllers
{ 
    [ApiController]
        [Route("api/[controller]")]
    public class MailController : Controller
    {
       
  
            private readonly IMailService mailService;
            public MailController(IMailService mailService)
            {
                this.mailService = mailService;
            }

            [HttpPost("Send")]
            public async Task<IActionResult> Send([FromForm] MailRequest request)
            {
                try
                {
                    await mailService.SendEmailAsync(request);
                    return Ok();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
}
