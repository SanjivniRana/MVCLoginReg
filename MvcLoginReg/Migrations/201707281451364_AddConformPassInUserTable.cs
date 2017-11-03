namespace MvcLoginReg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddConformPassInUserTable : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "ConformPassword", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Users", "ConformPassword");
        }
    }
}
