using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace EFGetStarted.AspNetCore.NewDb.Models
{
    public class BloggingContext : DbContext
    {
        public BloggingContext(DbContextOptions<BloggingContext> options)
            : base(options)
        { }
        public DbSet<PersonalInformation> Persons { get; set; }
    }

    public class PersonalInformation {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; }
        public string About { get; set; }
    }

    public class Newsletter
    {
        public string Email2 { get; set; }
    }

    public class Images
    {
        public int IdImg { get; set; }
        public object pic { get; set; }
    }
}