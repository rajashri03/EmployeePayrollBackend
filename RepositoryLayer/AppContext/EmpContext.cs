using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RepositoryLayer.AppContext
{
    public class EmpContext : DbContext
    {
        public EmpContext(DbContextOptions options)
            : base(options)
        {
        }
        public DbSet<UserEntity> Employees { get; set; }
    }
}
