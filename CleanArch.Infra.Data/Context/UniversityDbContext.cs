using CleanArch.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.Data.Context
{
    public class UniversityDbContext : DbContext
    {
        //public class UniversitDbContext(DbContextOptions options):base(options)

        public UniversityDbContext(DbContextOptions options):base(options)
         {
                
         }

        public DbSet<Course> Courses { get; set; }
    }
}

