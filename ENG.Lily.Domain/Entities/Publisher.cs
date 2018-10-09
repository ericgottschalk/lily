namespace ENG.Lily.Domain.Entities
{
    public class Publisher : User
    {
        public string CompanyName { get; set; }

        public bool IsVerified { get; set; }
    }
}
