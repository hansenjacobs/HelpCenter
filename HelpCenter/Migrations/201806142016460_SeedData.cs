namespace HelpCenter.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    using HelpCenter.Models;
    
    public partial class SeedData : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'1', N'Manager')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'2', N'Technician')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'3', N'LeaseHolder')");

            Sql("INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'dc253146-192e-4c38-b6e6-e020274f711d', N'manager@help.com', 0, N'AG/emQxgQ4mTc+T16JcqVoeV5G70aKdGpvHsIjW/RcNo2p78EdZM39Ip3y4a8kOlDQ==', N'8a078225-604f-4337-9785-b8c82bac1f41', NULL, 0, 0, NULL, 1, 0, N'manager@help.com')");
            Sql("INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'dc253146-192e-4c38-b6e6-e020274f711d', N'1')");
            var _context = new ApplicationDbContext();
            var managerAppUser = new AppUser()
            {
                Id = "dc253146-192e-4c38-b6e6-e020274f711d",
                NameFirst = "Manager",
                NameLast = "Manager",
                EmailAddress = "manager@help.com",
                PhoneNumber = "4148470000"
            };
            _context.AppUsers.Add(managerAppUser);
            _context.SaveChanges();

            Sql(@"SET IDENTITY_INSERT dbo.WorkOrderStatus ON
                INSERT INTO dbo.WorkOrderStatus (Id, Name, IsOpen) VALUES (1, 'NEW', 1)
                INSERT INTO dbo.WorkOrderStatus (Id, Name, IsOpen) VALUES (2, 'ASSIGNED', 1)
                INSERT INTO dbo.WorkOrderStatus (Id, Name, IsOpen) VALUES (3, 'IN PROGRESS', 1)
                INSERT INTO dbo.WorkOrderStatus (Id, Name, IsOpen) VALUES (4, 'COMPLETED', 0)
                SET IDENTITY_INSERT dbo.WorkOrderStatus OFF");

            Sql("SET IDENTITY_INSERT [dbo].[Locations] ON");
            Sql("INSERT INTO [dbo].[Locations]([Id], [Name], [Address], [City], [State], [Zip]) VALUES(1, N'Selenium Crossings', N'1888 N Water Ave', N'Milwaukee', N'WI', N'53202')");
            Sql("INSERT INTO [dbo].[Locations] ([Id], [Name], [Address], [City], [State], [Zip]) VALUES(2, N'Selenium River Run', N'270 E Highland Ave', N'Milwaukee', N'WI', N'53202')");
            Sql("INSERT INTO [dbo].[Locations] ([Id], [Name], [Address], [City], [State], [Zip]) VALUES(3, N'Selenium Estates', N'313 N Plankinton Ave ', N'Milwaukee', N'WI', N'53203')");
            Sql("SET IDENTITY_INSERT[dbo].[Locations] OFF ");

            Sql("SET IDENTITY_INSERT [dbo].[Units] ON");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (1, '101', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (2, '102', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (3, '103', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (4, '104', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (5, '105', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (6, '106', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (7, '107', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (8, '108', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (9, '109', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (10, '110', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (11, '201', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (12, '202', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (13, '203', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (14, '204', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (15, '205', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (16, '206', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (17, '207', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (18, '208', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (19, '301', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (20, '302', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (21, '303', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (22, '304', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (23, '305', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (24, '306', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (25, '307', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (26, '308', 1)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (27, '1A', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (28, '1B', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (29, '1C', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (30, '1D', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (31, '2A', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (32, '2B', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (33, '2C', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (34, '2D', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (35, 'Penthouse', 2)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (36, '1100A', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (37, '1100B', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (38, '1110A', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (39, '1110B', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (40, '1120A', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (41, '1120B', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (42, '1130A', 3)");
            Sql("INSERT INTO dbo.Units (Id, Number, LocationId) VALUES (43, '1130B', 3)");
            Sql("SET IDENTITY_INSERT [dbo].[Units] OFF");

            Sql("SET IDENTITY_INSERT [dbo].[WorkOrderCategories] ON");
            Sql("INSERT INTO dbo.WorkOrderCategories (Id, Name) VALUES (1, 'Applicance')");
            Sql("INSERT INTO dbo.WorkOrderCategories (Id, Name) VALUES (2, 'Electrical')");
            Sql("INSERT INTO dbo.WorkOrderCategories (Id, Name) VALUES (3, 'Internet')");
            Sql("INSERT INTO dbo.WorkOrderCategories (Id, Name) VALUES (4, 'Plumbing')");
            Sql("INSERT INTO dbo.WorkOrderCategories (Id, Name) VALUES (5, 'Other')");
            Sql("SET IDENTITY_INSERT [dbo].[WorkOrderCategories] OFF");


        }
        
        public override void Down()
        {
        }
    }
}
