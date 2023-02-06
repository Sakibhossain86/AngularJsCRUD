using AngularJS_Demo.Models;
using AngularJS_Demo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace AngularJS_Demo.Controllers.API
{
    public class MembersController : ApiController
    {
        IMemberRepo repo=null;
        public MembersController()
        {
            this.repo = new MemberRepo();
        }
        [HttpGet]
        public async Task<IEnumerable<Member>> GetMembers()
        {
            return await this.repo.GetMembersAsync();
        }
        [HttpGet()]
        [Route("{id}")]
        public async Task<Member> GetMember(int id)
        {
            return await this.repo.GetMemberAsync(id);
        }
        [HttpPost]
        
        public async Task<Member> PostMember(Member data)
        {
            await this.repo.InsertAsync(data);
            await this.repo.CompleteAsysnc();
            return data;
        }
        [HttpPut]
        [Route("{id}")]
        public async Task<Member> PostMember(int id, Member data)
        {
            await this.repo.UpdateAsync(data);
            await this.repo.CompleteAsysnc();
            return data;
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<Member> DeleteMember(int id, Member data)
        {
            await this.repo.DeleteAsync(data);
            await this.repo.CompleteAsysnc();
            return data;
        }
       
    }
}
