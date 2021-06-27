using CleanArchitecture.Domain.Models;

namespace CleanArchitecture.Domain.Models
{
    public class UserOperationClaim : Entity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
    }
}
