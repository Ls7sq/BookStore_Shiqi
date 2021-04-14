using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Book>().HasData
                (
                    new Book
                    {
                        Id = 1,
                        Name = "Design CAD",
                        Desc = "CAD Designers use technology to help generate designs for complex projects.",
                        UnitPrice = 89,
                        Image = "1.png"
                    },

                    new Book
                    {
                        Id = 2,
                        Name = "C#",
                        Desc = "Designers xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.",
                        UnitPrice = 77,
                        Image = "1.png"
                    },
                    new Book
                    {
                        Id = 3,
                        Name = ".Net Core",
                        Desc = "Designers xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx.",
                        UnitPrice = 66,
                        Image = "1.png"
                    }
                );

            //modelBuilder.Entity<Customer>().HasData
            //    (
            //        new Customer
            //        {
            //            Id = 1,
            //            UserName = "team5",
            //            Password = "123456"
            //        }
            //    );;
        }
    }
}
