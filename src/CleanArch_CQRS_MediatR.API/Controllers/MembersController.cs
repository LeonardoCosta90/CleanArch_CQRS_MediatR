using CleanArch_CQRS_MediatR.Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace CleanArch_CQRS_MediatR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MembersController : ControllerBase
    {

        private readonly IUnitOfWork _unitOfWork;
        public MembersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> GetMembers()
        {
            var members = await _unitOfWork.MemberRepository.GetMembers();
            return members != null ? Ok(members) : NotFound("Member not found.");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMember(int id)
        {
            var member = await _unitOfWork.MemberRepository.GetMemberById(id);
            return member != null ? Ok(member) : NotFound("Member not found.");
        }

    }
}