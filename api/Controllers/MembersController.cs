using System;
using System.Collections.Generic;

using EzraTest.DB;
using EzraTest.Models;

using Microsoft.AspNetCore.Mvc;

namespace EzraTest.Controllers
{
    [ApiController]
    [Route("members")]
    public class MembersController : ControllerBase
    {
        private readonly IMembersRepository _membersRepository;

        public MembersController()
        {
            _membersRepository = new MembersRepository("app.db");
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Member> GetAllMembers()
        {
            return _membersRepository.GetMembers();
        }

        [HttpGet]
        [Route("{id}")]
        public Member GetMember(Guid id)
        {
            return _membersRepository.GetMember(id);
        }

        // TODO
        // Choose a http method and route and complete the method
        public void AddMember(Member member)
        {
            _membersRepository.AddMember(member);
        }

        // TODO
        // Choose a http method and route and complete the method
        public void UpdateMember(Guid id, Member member)
        {
            _membersRepository.UpdateMember(id, member);
        }

        // TODO
        // Choose a http method and route and complete the method
        public void DeleteMember(Guid id)
        {
            _membersRepository.DeleteMember(id);
        }
    }
}
