using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace FAQ.App.Models
{
    public class FAQcontext: DbContext
    {
        public FAQcontext(DbContextOptions<FAQcontext> options)
            : base(options)
        { }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Topic> Topic { get; set; }
        public DbSet<FAQ> FAQ { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { Id = "gen", Name = "General" },
                 new Category { Id = "his", Name = "Hisotry" }
             );

            modelBuilder.Entity<Topic>().HasData(
                new Topic { Id = "cs", Name = "C#" },
                new Topic { Id = "bs", Name = "Bootstrap" },
                new Topic { Id = "js", Name = "Javascript" }
        );
            modelBuilder.Entity<FAQ>().HasData(
                new FAQ { Id = 1, Question = "What is Bootstrap?", Answer = "A CSS framework for creating responsive web apps for multipe screen sizes.", CategoryId = "gen", TopicId = "bs" },
                new FAQ { Id = 2, Question = "When was Bootstrap first released?", Answer = "In 2011.", CategoryId = "his", TopicId = "bs" },
                new FAQ { Id = 3, Question = "What is C#?", Answer = "A general purpose object oriented language that uses a concise, Java-like syntax.", CategoryId = "gen", TopicId = "cs" },
                new FAQ { Id = 4, Question = "When was C# first released?", Answer = "In 2002.", CategoryId = "his", TopicId = "cs" },
                new FAQ { Id = 5, Question = "What is JavaScript?", Answer = "A general purpose scipting language that executes in a web browser.", CategoryId = "gen", TopicId = "js" },
                new FAQ { Id = 6, Question = "When was JavaScript first released?", Answer = "In 1995.", CategoryId = "his", TopicId = "js" }
                );
        }
    }
}
