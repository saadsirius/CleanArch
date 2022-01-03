using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Domain.Interfaces
{
  public interface IFileTransferRepository
    {
        public IQueryable<FileTransfer> GetFileTransfers();
        public FileTransfer GetFileTransfer(int id);
        public void AddFile(FileTransfer ft);
    }
}
