using Microsoft.AspNetCore.Http;

namespace ENG.Lily.Api.Models
{
    public class UploadProfilePictureModel
    {
        public int Id { get; set; }

        public IFormFile File { get; set; }
    }
}
