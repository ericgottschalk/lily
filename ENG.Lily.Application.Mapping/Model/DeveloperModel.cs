using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class DeveloperModel : UserModel
    {
        public string Cpf { get; set; }

        public List<ProjectModel> Projects { get; set; }
    }
}
