using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-V44T9NQ\\SQLEXPRESS;database=Tech;Integrated security=true; TrustServerCertificate=true; MultipleActiveResultSets=true;");
        }
       
        public DbSet<About> Abouts { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceHeader> ServiceHeaders { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<TeamMember> TeamMembers { get; set; }

        public DbSet<ContactMail> ContactMails { get; set; }
    }
}
