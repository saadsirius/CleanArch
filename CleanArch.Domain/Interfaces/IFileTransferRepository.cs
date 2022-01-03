﻿using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
  public interface IFileTransferRepository
    {
        IEnumerable<FileTransfer> GetFileTransfers();
    }
}
