using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Data.Context
{
    public class CleanArchDBContext : DbContext
    {
        public CleanArchDBContext(DbContextOptions options) : base(options)
        {
        }
        //public DbSet<Course> Courses { get; set; }
        public DbSet<FileTransfer> FileTransfers { get; set; }
    }
}
