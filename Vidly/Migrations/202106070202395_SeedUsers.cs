namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9836d089-ee7b-491a-b24a-f9ffc7700e2d', N'admin@vidly.com', 0, N'ABX60qNz/rF9Rvxa6hyxUxrkzRvfrbg6izguUlT3mqOCW8nlBh3Ee2yinBVDlhkcBA==', N'ae4027aa-e684-4d28-8466-6dd11703bbac', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'a68861d3-1633-4e45-8cd7-86a2f81730f2', N'guest@vidly.com', 0, N'AGKutg49250CSDRplKObOVTxFq9QXxiO+R/RUSazFvo1vMgNRqZcfdPTfH1nZU/lzQ==', N'078bf279-b526-4bc7-b5e3-0eec2440c21f', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')

                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'05cd24fc-cc88-4f32-82f4-1787e89f4b30', N'CanManageMovies')
                
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'9836d089-ee7b-491a-b24a-f9ffc7700e2d', N'05cd24fc-cc88-4f32-82f4-1787e89f4b30')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
