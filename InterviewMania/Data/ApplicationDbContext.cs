using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InterviewMania.Models;
namespace InterviewMania.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
           
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Post>()
                 .HasOne<Category>(s => s.Category)
                 .WithMany(p => p.Posts)
                 .HasForeignKey(s => s.CatergoryId);

            modelBuilder.Entity<Post>()
             .HasOne<SubCategory>(s => s.SubCategory)
             .WithMany(p => p.Posts)
             .HasForeignKey(s => s.SubCategoryId)
             .OnDelete(DeleteBehavior.Cascade);



        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }

    }




    }


