using System;
using System.Collections.Generic;
using System.Text;
using Application.ViewModels;

namespace Application.Interfaces
{
   public interface IFileTransferService
    {
        IEnumerable<FileTransferViewModel> GetFileTransfers();

    }
}
