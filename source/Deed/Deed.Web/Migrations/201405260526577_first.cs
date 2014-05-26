namespace Deed.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Father = c.String(),
                        Mother = c.String(),
                        Birthday = c.DateTime(),
                        Class = c.String(),
                        Religion = c.String(),
                        Address = c.String(),
                        Village = c.String(),
                        PostOffice = c.String(),
                        PuliceStation = c.String(),
                        District = c.String(),
                        Caste = c.String(),
                        City = c.String(),
                        State = c.String(),
                        Country = c.String(),
                        History = c.String(),
                        Picture = c.String(),
                        Video = c.String(),
                        Target = c.Double(nullable: false),
                        Currency = c.String(),
                        Added = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        IsAchieved = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sponderships",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        StudentID = c.Long(nullable: false),
                        SponsorID = c.Long(nullable: false),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        Amount = c.Double(nullable: false),
                        Currency = c.String(),
                        IsFeatured = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.People", t => t.SponsorID, cascadeDelete: true)
                .ForeignKey("dbo.Students", t => t.StudentID, cascadeDelete: true)
                .Index(t => t.StudentID)
                .Index(t => t.SponsorID);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Picture = c.String(),
                        Video = c.String(),
                        IsFeatured = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            
            DropForeignKey("dbo.Sponderships", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Sponderships", "SponsorID", "dbo.People");
            
            DropIndex("dbo.Sponderships", new[] { "SponsorID" });
            DropIndex("dbo.Sponderships", new[] { "StudentID" });
            
            DropTable("dbo.People");
            DropTable("dbo.Sponderships");
            DropTable("dbo.Students");
            
        }
    }
}
