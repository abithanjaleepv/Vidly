﻿namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNumberAvailableToMovie1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Movies", "NumberAvailable1", c => c.Int(nullable: false));
            Sql("UPDATE Movies SET NumberAvailable1 = NumberInStock");

            DropColumn("dbo.Movies", "NumberAvailable");
        }
        
        public override void Down()
        {
            
        }
    }
}
