using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace NIPQuest.DAL
{
    public class CompanyDBInitializer : DropCreateDatabaseAlways<CompanyContext>
    {
        protected override void Seed(CompanyContext context)
        {

        context.CompanyTable.AddOrUpdate(
                new Models.Company() { CompanyId = 1, NIP= "7777777777", Name = "MSR TRAFFIC sp. z o.o.", Street= "Kamienna", Number =7, PostCode ="23-342", City ="Wysogotowo" },
                new Models.Company() { CompanyId = 2, NIP = "8887777777", Name = "Alma S.A.", Street = "Hodowlana", Number = 5, PostCode = "61-680", City = "Poznań" },
                new Models.Company() { CompanyId = 3, NIP = "2227777777", Name = "Budikom", Street = "Czechosłowacka", Number = 16, PostCode = "60-101", City = "Poznań" });

        context.LogInfoTable.AddOrUpdate(
                   new Models.LogInfo() { LogId = 1, NumberNIP = "4377777777" });

            base.Seed(context);
        }
    }
}