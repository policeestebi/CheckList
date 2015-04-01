namespace TriQuint.CheckList.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTestCheckListItemTemplate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CheckListTemplate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        InsertedUser = c.String(),
                        InsertedDate = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(),
                        LastUpdateDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.TemplateSection",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TemplateSectonID = c.String(),
                        InsertedUser = c.String(),
                        InsertedDate = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(),
                        LastUpdateDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        TemplateSectionParent_ID = c.Int(),
                        CheckListTemplate_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TemplateSection", t => t.TemplateSectionParent_ID)
                .ForeignKey("dbo.CheckListTemplate", t => t.CheckListTemplate_ID)
                .Index(t => t.TemplateSectionParent_ID)
                .Index(t => t.CheckListTemplate_ID);
            
            CreateTable(
                "dbo.CheckListItemTemplate",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        TemplateSectionID = c.String(),
                        Test = c.String(),
                        InsertedUser = c.String(),
                        InsertedDate = c.DateTime(nullable: false),
                        LastUpdateUser = c.String(),
                        LastUpdateDate = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        TemplateSection_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.TemplateSection", t => t.TemplateSection_ID)
                .Index(t => t.TemplateSection_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TemplateSection", "CheckListTemplate_ID", "dbo.CheckListTemplate");
            DropForeignKey("dbo.TemplateSection", "TemplateSectionParent_ID", "dbo.TemplateSection");
            DropForeignKey("dbo.CheckListItemTemplate", "TemplateSection_ID", "dbo.TemplateSection");
            DropIndex("dbo.CheckListItemTemplate", new[] { "TemplateSection_ID" });
            DropIndex("dbo.TemplateSection", new[] { "CheckListTemplate_ID" });
            DropIndex("dbo.TemplateSection", new[] { "TemplateSectionParent_ID" });
            DropTable("dbo.CheckListItemTemplate");
            DropTable("dbo.TemplateSection");
            DropTable("dbo.CheckListTemplate");
        }
    }
}
