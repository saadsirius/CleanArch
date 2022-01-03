using CleanArch.Data.Context;
using Domain.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
   public class FileTransferRepository : IFileTransferRepository
    {
        private CleanArchDBContext _context;
        public FileTransferRepository(CleanArchDBContext context)
        {
            _context = context;
        }
        public IEnumerable<FileTransfer> GetFileTransfers()
        {
            throw new NotImplementedException();
        }
    }
}
