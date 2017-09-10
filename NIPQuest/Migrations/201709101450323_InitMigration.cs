namespace NIPQuest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Companies",
                c => new
                    {
                        CompanyId = c.Int(nullable: false, identity: true),
                        NIP = c.String(),
                        Name = c.String(),
                        Street = c.String(),
                        Number = c.Int(nullable: false),
                        PostCode = c.String(),
                        City = c.String(),
                    })
                .PrimaryKey(t => t.CompanyId);
            
            CreateTable(
                "dbo.LogInfoes",
                c => new
                    {
                        LogId = c.Int(nullable: false, identity: true),
                        NumberNIP = c.String(),
                        logDate = c.String(),
                        Connection = c.String(),
                        Accept = c.String(),
                        Accept_Encoding = c.String(),
                        Accept_Language = c.String(),
                        Cookie = c.String(),
                        Host = c.String(),
                        Referer = c.String(),
                        User_Agent = c.String(),
                    })
                .PrimaryKey(t => t.LogId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.LogInfoes");
            DropTable("dbo.Companies");
        }
    }
}
