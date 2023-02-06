namespace AngularJS_Demo.Migrations
{
    using AngularJS_Demo.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AngularJS_Demo.Models.MemberDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(AngularJS_Demo.Models.MemberDbContext context)
        {
            context.Members.Add(new Member { Name = "Member 1", District = "Dhaka", Thana = "Kafrul", Gender = Gender.Male, Phone = "01710-888999" });
            context.SaveChanges();
        }
    }
}
