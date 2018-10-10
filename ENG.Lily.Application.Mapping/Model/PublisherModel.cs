using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class PublisherModel : UserModel
    {
        public string CompanyName { get; set; }

        public bool IsVerified { get; set; }

        public List<GameModel> Games { get; set; }
    }
}
