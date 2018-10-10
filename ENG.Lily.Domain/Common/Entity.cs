namespace ENG.Lily.Domain.Common
{
    public class Entity
    {
        public int Id { get; set; }

        public bool IsNew() => this.Id == 0;
    }
}
