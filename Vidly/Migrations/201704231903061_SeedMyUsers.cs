namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedMyUsers : DbMigration
    {
        public override void Up()
        {

            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0a42a3ba-0170-46ed-93fd-b3210425f2e6', N'rahmikg@yahoo.com', 0, N'AP2pGDeqW1LAD7OBPFHPPKmbt1z77tFmuyiVybRXGZ8llBZzYtSN6TJojGdbGeh25Q==', N'4b7b0bb7-0745-4213-b400-b573336fb9e5', NULL, 0, 0, NULL, 1, 0, N'rahmikg@yahoo.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a35a94bb-b06d-4c65-899a-dc398a1b29e1', N'admin@vidly.com', 0, N'ANW2qr6m09DiJ3jHgGnYnDq6PrxONMPA1lb2DeOGgDjrAT6nsxdV6cPd6nPuoLwAxw==', N'00b5f880-da4b-4a75-8f03-312f71da9bde', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'03b19cf8-ece5-4305-b9df-d8d0df0d63bd', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a35a94bb-b06d-4c65-899a-dc398a1b29e1', N'03b19cf8-ece5-4305-b9df-d8d0df0d63bd')



");

        }
        
        public override void Down()
        {
        }
    }
}
