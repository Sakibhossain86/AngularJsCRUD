using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AngularJS_Demo.Models
{
    public enum Gender { Male, Female }
    public class Member
    {
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, StringLength(20), RegularExpression(@"^\d{5}[-]?\d{6}\r?$", ErrorMessage ="Phone invalid, example: 01710999888 or 01810-999888")]
        public string Phone { get; set; }
        [Required, StringLength(50)]
        public string District { get; set; }
        [Required, StringLength(50)]
        public string Thana { get; set; }
        [Required, EnumDataType(typeof(Gender))]
        public Gender Gender { get; set; }
    }
    public class MemberDbContext : DbContext
    {
        public DbSet<Member> Members { get; set; }
    }
}