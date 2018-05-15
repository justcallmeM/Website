using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using experiment1.Models;
using EFGetStarted.AspNetCore.NewDb.Models;
using System.IO;
using Microsoft.CSharp.RuntimeBinder;
using Microsoft.EntityFrameworkCore;

namespace experiment1.Controllers
{
    public class HomeController : Controller
    {
        private readonly BloggingContext context;

        public HomeController(BloggingContext context)
        {
            this.context = context;
        }

        public IActionResult AboutMindaugas()
        {
            ViewData ["Message"] = "About Mindaugas.";

            try
            {
                var person = context.Persons
                    .First<PersonalInformation>(p => p.Name.Equals("Mindaugas Pikelis"));

                return View(person);
            }
            catch (InvalidOperationException ex)
            {

                var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
                var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
                optionsBuilder.UseSqlServer(connection);
                using (var context = new BloggingContext(optionsBuilder.Options))
                {
                    context.Database.OpenConnection();
                    context.Set<PersonalInformation>();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Persons ON");
                    PersonalInformation pers = new PersonalInformation { Id = 101, Name = "Mindaugas Pikelis", PlaceOfBirth = "Panevezys, Lithuania", DateOfBirth = new DateTime(1996, 07, 23, 12, 02, 30), About = "" };
                    context.Persons.Add(pers);
                    context.SaveChanges();
                    context.Database.CloseConnection();
                }
                var person = context.Persons
                .First<PersonalInformation>(p => p.Name.Equals("Mindaugas Pikelis"));

                return View(person);

            }

        }

        public IActionResult GalleryMindaugas()
        {
            ViewData["Message"] = "Gallery Mindaugas.";

            return View();
        }

        public IActionResult AboutCristian()
        {
            ViewData["Message"] = "About Cristian.";

            try { 
            var person = context.Persons
                .First<PersonalInformation>(p => p.Name.Equals("Cristian Ceruta"));

            return View(person);
            }
            catch (InvalidOperationException ex )
            {
                
                var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
                var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
                optionsBuilder.UseSqlServer(connection);
                using (var context = new BloggingContext(optionsBuilder.Options))
                {
                    context.Database.OpenConnection();
                    context.Set<PersonalInformation>();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Persons ON");
                    PersonalInformation pers = new PersonalInformation { Id = 100, Name = "Cristian Ceruta", PlaceOfBirth = "Balti, Moldova", DateOfBirth= new DateTime(1996,06,24,4 ,24,20), About="" };
                    context.Persons.Add(pers);
                    context.SaveChanges();
                    context.Database.CloseConnection();
                }
                var person = context.Persons
                .First<PersonalInformation>(p => p.Name.Equals("Cristian Ceruta"));

                return View(person);
               
            }

        }

        public IActionResult GalleryCristian()
        {
            ViewData["Message"] = "Gallery Cristian.";

         

            return View();
        }

        public IActionResult AboutJohanna()
        {
            ViewData["Message"] = "About Johanna.";

            try
            {
                var person = context.Persons
                    .First<PersonalInformation>(p => p.Name.Equals("Johanna Brosig"));

                return View(person);
            }
            catch (InvalidOperationException ex)
            {

                var optionsBuilder = new DbContextOptionsBuilder<BloggingContext>();
                var connection = @"Server=(localdb)\mssqllocaldb;Database=EFGetStarted.AspNetCore.NewDb;Trusted_Connection=True;ConnectRetryCount=0";
                optionsBuilder.UseSqlServer(connection);
                using (var context = new BloggingContext(optionsBuilder.Options))
                {
                    context.Database.OpenConnection();
                    context.Set<PersonalInformation>();
                    context.Database.ExecuteSqlCommand("SET IDENTITY_INSERT dbo.Persons ON");
                    PersonalInformation pers = new PersonalInformation { Id = 102, Name = "Johanna Brosig", PlaceOfBirth = "Wismar, Germany", DateOfBirth = new DateTime(1995, 07, 20, 00, 08, 20), About = "" };
                    context.Persons.Add(pers);
                    context.SaveChanges();
                    context.Database.CloseConnection();
                }
                var person = context.Persons
                .First<PersonalInformation>(p => p.Name.Equals("Johanna Brosig"));

                return View(person);

            }

        }

        public IActionResult GalleryJohanna()
        {
            ViewData["Message"] = "Gallery Johanna.";

            return View();
        }

        public IActionResult Newsletter(string Email2)
        {
            ViewData["Message"] = "Newsletter.";

            string EmailEntered = Email2;

            using (StreamWriter email = new StreamWriter("emailDatabase.txt", true)) //// true to append data to the file
            {
                email.WriteLine($"{EmailEntered}");
            }

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
