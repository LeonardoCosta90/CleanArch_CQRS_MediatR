namespace CleanArch_CQRS_MediatR.Domain.Entities
{
    public abstract class Entity
    {
        public int Id { get; protected set; }
    }
}