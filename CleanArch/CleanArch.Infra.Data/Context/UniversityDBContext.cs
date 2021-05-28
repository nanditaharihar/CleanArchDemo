using Microsoft.EntityFrameworkCore;
using System;
using CleanArch.Domain.Models;

namespace CleanArch.Infra.Data
{
    public class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions options):base(options)
        {


        }
       public DbSet<Course> Courses { get; set; }
    }
}
