using NIPQuest.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NIPQuest.DAL
{
    public class CompanyContext : DbContext
    {
        public CompanyContext() :base("CompanyInfoDatabase")
        {
            ///Seed
            //Database.SetInitializer(new CompanyDBInitializer());
        }

        public DbSet<Company> CompanyTable { get; set; }
        public DbSet<LogInfo> LogInfoTable { get; set; }
    }
}