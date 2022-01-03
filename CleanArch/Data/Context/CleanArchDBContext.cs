using Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Data.Context
{
    public class CleanArchDBContext : IdentityDbContext
    {
        public CleanArchDBContext(DbContextOptions<CleanArchDBContext> options) : base(options)
        {
        }
        public DbSet<FileTransfer> FileTransfers { get; set; }
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseLazyLoadingProxies();
        //}
    }
}
