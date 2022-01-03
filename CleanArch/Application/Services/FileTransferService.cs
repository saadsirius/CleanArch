using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Application.Services
{
    public class FileTransferService: IFileTransferService
    {
        private IFileTransferRepository fileTransferRepository;

        public FileTransferService(IFileTransferRepository fileTransferRepository)
            {
                this.fileTransferRepository = fileTransferRepository;
            }
        public FileTransferViewModel GetFileTransfer(int id)
        {
            var fileTransfer = fileTransferRepository.GetFileTransfer(id);
            var result = new FileTransferViewModel()
            {
                Id = fileTransfer.Id,
                Email = fileTransfer.Email,
                ToEmail = fileTransfer.ToEmail,
                Title = fileTransfer.Title,
                Message = fileTransfer.Message,
                Password = fileTransfer.Password,
                FileName = fileTransfer.FileName
            };
            return result;
        }

        public IQueryable<FileTransferViewModel> GetFileTransfers()
        {
            var list = from f in fileTransferRepository.GetFileTransfers()
                       select new FileTransferViewModel()
                       {
                           Id = f.Id,
                           Email = f.Email,
                           ToEmail = f.ToEmail,
                           Title = f.Title,
                           Message = f.Message,
                           Password = f.Password,
                           FileName = f.FileName
                       };
            return list;
        }

        public void AddFile(FileTransferViewModel model)
        {
            fileTransferRepository.AddFile(
                new Domain.Models.FileTransfer()
                {
                    FileName = model.FileName,
                    Id = model.Id
                });
        }
    }
}
