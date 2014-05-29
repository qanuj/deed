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
                        Address = c.String(),
                        Village = c.String(),
                        PostOffice = c.String(),
                        PuliceStation = c.String(),
                        District = c.String(),
                        Caste = c.String(),
                        History = c.String(),
                        Picture = c.String(),
                        Video = c.String(),
                        Target = c.Double(nullable: false),
                        Currency = c.String(),
                        Added = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        IsFeatured = c.Boolean(nullable: false),
                        IsAchieved = c.Boolean(nullable: false),
                        Country_ID = c.Long(),
                        City_ID = c.Long(),
                        Religion_ID = c.Long(),
                        State_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .ForeignKey("dbo.Cities", t => t.City_ID)
                .ForeignKey("dbo.Religions", t => t.Religion_ID)
                .ForeignKey("dbo.States", t => t.State_ID)
                .Index(t => t.Country_ID)
                .Index(t => t.City_ID)
                .Index(t => t.Religion_ID)
                .Index(t => t.State_ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        State_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.States", t => t.State_ID)
                .Index(t => t.State_ID);
            
            CreateTable(
                "dbo.States",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Country_ID = c.Long(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Countries", t => t.Country_ID)
                .Index(t => t.Country_ID);
            
            CreateTable(
                "dbo.Countries",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Religions",
                c => new
                    {
                        ID = c.Long(nullable: false, identity: true),
                        Name = c.String(),
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
            
            DropForeignKey("dbo.Students", "State_ID", "dbo.States");
            DropForeignKey("dbo.Sponderships", "StudentID", "dbo.Students");
            DropForeignKey("dbo.Sponderships", "SponsorID", "dbo.People");
            DropForeignKey("dbo.Students", "Religion_ID", "dbo.Religions");
            DropForeignKey("dbo.Students", "City_ID", "dbo.Cities");
            DropForeignKey("dbo.Students", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.States", "Country_ID", "dbo.Countries");
            DropForeignKey("dbo.Cities", "State_ID", "dbo.States");
           
            
            DropIndex("dbo.Sponderships", new[] { "SponsorID" });
            DropIndex("dbo.Sponderships", new[] { "StudentID" });
            DropIndex("dbo.States", new[] { "Country_ID" });
            DropIndex("dbo.Cities", new[] { "State_ID" });
            DropIndex("dbo.Students", new[] { "State_ID" });
            DropIndex("dbo.Students", new[] { "Religion_ID" });
            DropIndex("dbo.Students", new[] { "City_ID" });
            DropIndex("dbo.Students", new[] { "Country_ID" });
            
            DropTable("dbo.People");
            DropTable("dbo.Sponderships");
            DropTable("dbo.Religions");
            DropTable("dbo.Countries");
            DropTable("dbo.States");
            DropTable("dbo.Cities");
            DropTable("dbo.Students");
            
        }
    }
}
