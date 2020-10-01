
using Microsoft.EntityFrameworkCore;
using SignToSeminarBackEnd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SignToSeminarie
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet <Visitor> Visitors { set; get; }
        public DbSet<Seminar> Seminars { set; get; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-68VOS8N\MSSQLSERVER01;Database=SignToSeminarie;Trusted_connection=true");
        }
    }

    
}
