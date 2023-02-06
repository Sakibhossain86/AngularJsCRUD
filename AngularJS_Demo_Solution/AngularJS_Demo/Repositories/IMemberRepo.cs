using AngularJS_Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngularJS_Demo.Repositories
{
    public interface IMemberRepo
    {
        Task<IEnumerable<Member>> GetMembersAsync();
        Task<Member> GetMemberAsync(int id);
        Task InsertAsync(Member member);
        Task UpdateAsync(Member member);
        Task DeleteAsync(Member member);
        Task CompleteAsysnc();
    }
}
