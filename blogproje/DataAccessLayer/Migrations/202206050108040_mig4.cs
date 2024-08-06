namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Authors", "Author_Password", c => c.String(maxLength: 25));
            AddColumn("dbo.Authors", "Author_Mail", c => c.String(maxLength: 55));
            AddColumn("dbo.Authors", "Author_Phone", c => c.String(maxLength: 20));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Authors", "Author_Phone");
            DropColumn("dbo.Authors", "Author_Mail");
            DropColumn("dbo.Authors", "Author_Password");
        }
    }
}
