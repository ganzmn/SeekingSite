namespace SeekingPuraVida.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BlogModelChange : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BlogSections", "Blog_BlogId", "dbo.Blogs");
            DropIndex("dbo.BlogSections", new[] { "Blog_BlogId" });
            CreateTable(
                "dbo.ImageLists",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        ImageLocation = c.String(),
                        Blog_BlogId = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId)
                .Index(t => t.Blog_BlogId);
            
            AddColumn("dbo.Blogs", "BlogBody", c => c.String());
            DropColumn("dbo.BlogSections", "Blog_BlogId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.BlogSections", "Blog_BlogId", c => c.Int());
            DropForeignKey("dbo.ImageLists", "Blog_BlogId", "dbo.Blogs");
            DropIndex("dbo.ImageLists", new[] { "Blog_BlogId" });
            DropColumn("dbo.Blogs", "BlogBody");
            DropTable("dbo.ImageLists");
            CreateIndex("dbo.BlogSections", "Blog_BlogId");
            AddForeignKey("dbo.BlogSections", "Blog_BlogId", "dbo.Blogs", "BlogId");
        }
    }
}
