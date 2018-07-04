namespace SeekingPuraVida.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class blogsectionupdates : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogSections", "SectionTitle", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogSections", "SectionTitle");
        }
    }
}
