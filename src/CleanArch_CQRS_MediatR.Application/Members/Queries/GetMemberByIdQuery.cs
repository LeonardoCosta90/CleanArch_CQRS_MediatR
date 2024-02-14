using CleanArch_CQRS_MediatR.Domain.Abstractions;
using CleanArch_CQRS_MediatR.Domain.Entities;
using MediatR;

namespace CleanArch_CQRS_MediatR.Application.Members.Queries;

public class GetMemberByIdQuery : IRequest<Member>
{
    public int Id { get; set; }

    public class GetMemberByIdQueryHandler : IRequestHandler<GetMemberByIdQuery, Member>
    {
        private readonly IMemberDapperRepository _memberDapperRepository;

        public GetMemberByIdQueryHandler(IMemberDapperRepository memberDapperRepository)
        {
            _memberDapperRepository = memberDapperRepository;
        }
        public async Task<Member> Handle(GetMemberByIdQuery request, CancellationToken cancellationToken)
        {
            var member = await _memberDapperRepository.GetMemberById(request.Id);
            return member;
        }
    }
}