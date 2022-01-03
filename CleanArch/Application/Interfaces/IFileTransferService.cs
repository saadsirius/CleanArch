using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.ViewModels;

namespace Application.Interfaces
{
    public interface IFileTransferService
    {
        public IQueryable<FileTransferViewModel> GetFileTransfers();
        public FileTransferViewModel GetFileTransfer(int id);
        public void AddFile(FileTransferViewModel model);

    }
}
