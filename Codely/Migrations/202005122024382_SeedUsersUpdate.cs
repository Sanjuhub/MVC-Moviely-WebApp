namespace Codely.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsersUpdate : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'16d759ef-6b22-4cb4-ac55-7be8d6eba1bb', N'Guest@codely.com', 0, N'AE4GcDuHY0orGIYWTOQGvRqgFBmynuwuNZAA/3e7Kc3HTDVbL5Mhfr9pP0Dxm/3b4Q==', N'ba7b5c7e-4574-4a28-b635-b49ccadbc79f', NULL, 0, 0, NULL, 1, 0, N'Guest@codely.com')

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'552438dd-7c7c-45aa-af21-66fe49ad1afc', N'admin@codely.com', 0, N'AKgPoHgR4vVho4gxGyJJPhQQc5zIxJVdoG4jHQl0URgiJUMU6bu6jId+vilufNlMXA==', N'55d89965-366d-4037-bc91-150c677fc8af', NULL, 0, 0, NULL, 1, 0, N'admin@codely.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4d6aee1f-9579-4687-932c-8e53359bf025', N'CanManageMovies')


INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'552438dd-7c7c-45aa-af21-66fe49ad1afc', N'4d6aee1f-9579-4687-932c-8e53359bf025')

");
        }
        
        public override void Down()
        {
        }
    }
}
