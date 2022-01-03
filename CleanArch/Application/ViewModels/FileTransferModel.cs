using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels
{
    public class FileTransferViewModel
    {
        public IEnumerable<FileTransfer> FileTransfers { get; set; }
    }
}
