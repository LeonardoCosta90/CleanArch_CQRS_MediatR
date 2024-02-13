namespace CleanArch_CQRS_MediatR.Domain.Abstractions;

public interface IUnitOfWork
{
    IMemberRepository MemberRepository { get; }
    Task CommitAsync();
}