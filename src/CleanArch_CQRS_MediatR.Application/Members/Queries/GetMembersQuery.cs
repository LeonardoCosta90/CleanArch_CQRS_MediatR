﻿using CleanArch_CQRS_MediatR.Domain.Abstractions;
using CleanArch_CQRS_MediatR.Domain.Entities;
using MediatR;

namespace CleanArch_CQRS_MediatR.Application.Members.Queries;

public class GetMembersQuery : IRequest<IEnumerable<Member>>
{
    public class GetMembersQueryHandler : IRequestHandler<GetMembersQuery, IEnumerable<Member>>
    {
        private readonly IMemberDapperRepository _memberDapperRepository;

        public GetMembersQueryHandler(IMemberDapperRepository memberDapperRepository)
        {
            _memberDapperRepository = memberDapperRepository;
        }
        public async Task<IEnumerable<Member>> Handle(GetMembersQuery request, CancellationToken cancellationToken)
        {
            var members = await _memberDapperRepository.GetMembers();
            return members;
        }
    }
}