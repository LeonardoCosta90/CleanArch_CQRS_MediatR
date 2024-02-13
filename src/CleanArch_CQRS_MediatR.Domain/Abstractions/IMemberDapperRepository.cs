using CleanArch_CQRS_MediatR.Domain.Entities;

namespace CleanArch_CQRS_MediatR.Domain.Abstractions;

public interface IMemberDapperRepository
{
    Task<IEnumerable<Member>> GetMembers();
    Task<Member> GetMemberById(int id);
}