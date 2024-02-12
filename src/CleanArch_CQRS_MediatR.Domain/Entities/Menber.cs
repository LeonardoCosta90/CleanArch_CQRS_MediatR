namespace CleanArch_CQRS_MediatR.Domain.Entities
{
    public sealed class Menber : Entity
    {
        public string? FirstName { get; private set; }
        public string? LastName { get; private set; }
        public string? Gender { get; private set; }
        public string? Email { get; private set; }
        public bool? IsActive { get; private set; }
    }
}