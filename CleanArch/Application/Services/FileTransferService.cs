using Application.Interfaces;
using Application.ViewModels;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class FileTransferService: IFileTransferService
    {
            private IFileTransferRepository _fileTransferRepository;
            public FileTransferService(IFileTransferRepository fileTransferRepository)
            {
                _fileTransferRepository = fileTransferRepository;
            }
            public IEnumerable<FileTransferViewModel> GetFileTransfers()
            {
                throw new NotImplementedException();
            }
        }
}
