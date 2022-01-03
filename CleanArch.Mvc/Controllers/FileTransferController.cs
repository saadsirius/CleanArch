using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Presentation.Controllers
{
    public class FileTransferController : Controller
    {
        private IFileTransferService fileTransfersService;
        private IWebHostEnvironment hostEnv;
        private ILogger<FileTransferController> logger;

        public FileTransferController(ILogger<FileTransferController> logger, IFileTransferService fileTransfersService, IWebHostEnvironment hostEnv)
        {
            this.fileTransfersService = fileTransfersService;
            this.hostEnv = hostEnv;
            this.logger = logger;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(FileTransferViewModel model, IFormFile logoFile)
        {
            //logger.Log(LogLevel.Information, $"{User.Identity.Name} is uploading a file called {logoFile.FileName}");

            try
            {
                if (ModelState.IsValid)
                {
                    if (logoFile != null)
                    {
                        //1. Unique file name Generation
                        string newFilename = Guid.NewGuid() + Path.GetExtension(logoFile.FileName);
                        logger.Log(LogLevel.Information, $"New filename {newFilename} was generated for the file being uploaded by user {User.Identity.Name}");
                        //2. find what the absolute path to the folder Files is
                        //C:~/Presentation\Files\*.jpg
                        //hostEnv.WebRootPath:  C:\~\Presentation\wwwroot
                        //hostEnv.ContentRootPath : C:\Presentation

                        string absolutePath = hostEnv.WebRootPath + "\\Files";
                        logger.Log(LogLevel.Information, $"{User.Identity.Name} is about to start saving file at {absolutePath}");

                        string absolutePathWithFilename = absolutePath + "\\" + newFilename;
                        model.FileName = "\\Files\\" + newFilename;
                        //3. transfer/saving of the actual physical file

                        using (FileStream fs = new FileStream(absolutePathWithFilename, FileMode.CreateNew, FileAccess.Write))
                        {
                            logoFile.CopyTo(fs);
                            fs.Close();
                        }
                        logger.Log(LogLevel.Information, $"{newFilename} has been saved successfully at {absolutePath}");
                    }

                    fileTransfersService.AddFile(model);
                    ViewBag.Message = "File added successfully";
                }
            }
            catch (Exception e)
            {
                ViewBag.Error = "File wasn't added successfully";
            }

            return View();
        }
    }

}
