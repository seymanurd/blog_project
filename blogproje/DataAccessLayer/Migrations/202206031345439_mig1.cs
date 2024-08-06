namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.subscription_by_mail",
                c => new
                    {
                        Mail_ID = c.Int(nullable: false, identity: true),
                        eMail_Adress = c.String(maxLength: 65),
                    })
                .PrimaryKey(t => t.Mail_ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.subscription_by_mail");
        }
    }
}
