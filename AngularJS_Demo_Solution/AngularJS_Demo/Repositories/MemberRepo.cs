using AngularJS_Demo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace AngularJS_Demo.Repositories
{
    public class MemberRepo : IMemberRepo
    {
        MemberDbContext db;
        public MemberRepo()
        {
            this.db = new MemberDbContext();
        }

        public async Task CompleteAsysnc()
        {
            await this.db.SaveChangesAsync();
        }

        public Task DeleteAsync(Member member)
        {
            throw new NotImplementedException();
        }

        public async Task<Member> GetMemberAsync(int id)
        {
            return await this.db.Members.FirstOrDefaultAsync(x => x.Id == id); ;
        }

        public async Task<IEnumerable<Member>> GetMembersAsync()
        {
            return await db.Members.ToListAsync();
        }

        public async Task InsertAsync(Member member)
        {
             this.db.Members.Add(member);
            await Task.CompletedTask;
        }

        public Task UpdateAsync(Member member)
        {
            throw new NotImplementedException();
        }
    }
}