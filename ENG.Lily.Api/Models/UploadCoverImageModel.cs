using Microsoft.AspNetCore.Http;

namespace ENG.Lily.Api.Models
{
    public class UploadCoverImageModel
    {
        public int IdProject { get; set; }

        public int IdUser { get; set; }

        public IFormFile File { get; set; }
    }
}
