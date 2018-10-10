using System.Collections.Generic;

namespace ENG.Lily.Application.Mapping.Model
{
    public class PlatformModel : Model
    {
        public string Name { get; set; }

        public string Code { get; set; }

        public List<ProjectModel> Projects { get; set; }
    }
}