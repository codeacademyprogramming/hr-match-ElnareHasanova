namespace HR_match.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CVs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Surname = c.String(nullable: false),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Study = c.String(),
                        WorkExperience = c.String(),
                        Category = c.String(),
                        City = c.String(),
                        MininumSalary = c.Int(nullable: false),
                        Mobile = c.String(maxLength: 13),
                        EmployeeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Employees", t => t.EmployeeId, cascadeDelete: true)
                .Index(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vacancies",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        VacancieName = c.String(nullable: false),
                        CompanyName = c.String(nullable: false),
                        Description = c.String(),
                        City = c.String(nullable: false),
                        Salary = c.Int(nullable: false),
                        Age = c.Int(nullable: false),
                        Study = c.String(),
                        WorkExperience = c.String(),
                        Mobile = c.String(maxLength: 13),
                        HrId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.HRs", t => t.HrId, cascadeDelete: true)
                .Index(t => t.HrId);
            
            CreateTable(
                "dbo.HRs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 15),
                        Email = c.String(nullable: false, maxLength: 50),
                        Status = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.VacancieEmployees",
                c => new
                    {
                        Vacancie_Id = c.Int(nullable: false),
                        Employee_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Vacancie_Id, t.Employee_Id })
                .ForeignKey("dbo.Vacancies", t => t.Vacancie_Id, cascadeDelete: true)
                .ForeignKey("dbo.Employees", t => t.Employee_Id, cascadeDelete: true)
                .Index(t => t.Vacancie_Id)
                .Index(t => t.Employee_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CVs", "EmployeeId", "dbo.Employees");
            DropForeignKey("dbo.Vacancies", "HrId", "dbo.HRs");
            DropForeignKey("dbo.VacancieEmployees", "Employee_Id", "dbo.Employees");
            DropForeignKey("dbo.VacancieEmployees", "Vacancie_Id", "dbo.Vacancies");
            DropIndex("dbo.VacancieEmployees", new[] { "Employee_Id" });
            DropIndex("dbo.VacancieEmployees", new[] { "Vacancie_Id" });
            DropIndex("dbo.Vacancies", new[] { "HrId" });
            DropIndex("dbo.CVs", new[] { "EmployeeId" });
            DropTable("dbo.VacancieEmployees");
            DropTable("dbo.HRs");
            DropTable("dbo.Vacancies");
            DropTable("dbo.Employees");
            DropTable("dbo.CVs");
        }
    }
}
