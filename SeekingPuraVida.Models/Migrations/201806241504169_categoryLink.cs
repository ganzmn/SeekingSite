namespace SeekingPuraVida.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryLink : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Categories", "Blog_BlogId", "dbo.Blogs");
            DropIndex("dbo.Categories", new[] { "Blog_BlogId" });
            CreateTable(
                "dbo.CategoryBlogs",
                c => new
                    {
                        Category_CategoryId = c.Int(nullable: false),
                        Blog_BlogId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Category_CategoryId, t.Blog_BlogId })
                .ForeignKey("dbo.Categories", t => t.Category_CategoryId, cascadeDelete: true)
                .ForeignKey("dbo.Blogs", t => t.Blog_BlogId, cascadeDelete: true)
                .Index(t => t.Category_CategoryId)
                .Index(t => t.Blog_BlogId);
            
            DropColumn("dbo.Categories", "Blog_BlogId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "Blog_BlogId", c => c.Int());
            DropForeignKey("dbo.CategoryBlogs", "Blog_BlogId", "dbo.Blogs");
            DropForeignKey("dbo.CategoryBlogs", "Category_CategoryId", "dbo.Categories");
            DropIndex("dbo.CategoryBlogs", new[] { "Blog_BlogId" });
            DropIndex("dbo.CategoryBlogs", new[] { "Category_CategoryId" });
            DropTable("dbo.CategoryBlogs");
            CreateIndex("dbo.Categories", "Blog_BlogId");
            AddForeignKey("dbo.Categories", "Blog_BlogId", "dbo.Blogs", "BlogId");
        }
    }
}
