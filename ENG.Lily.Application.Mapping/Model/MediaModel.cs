namespace ENG.Lily.Application.Mapping.Model
{ 
    public class MediaModel : Model
    {
        public string Url { get; set; }

        public int ProjectId { get; set; }
        public ProjectModel Project { get; set; }
    }
}