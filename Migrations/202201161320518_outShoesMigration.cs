﻿namespace ShoesStoreWebApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class outShoesMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OutShoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Company = c.String(),
                        Gender = c.String(),
                        IsHeels = c.Boolean(nullable: false),
                        IsExsist = c.Boolean(nullable: false),
                        Price = c.Int(nullable: false),
                        Size = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.OutShoes");
        }
    }
}
