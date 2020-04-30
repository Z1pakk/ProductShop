namespace BankomatLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedcategorytable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tblCategories");
        }
    }
}
