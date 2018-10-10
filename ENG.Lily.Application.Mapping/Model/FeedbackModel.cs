namespace ENG.Lily.Application.Mapping.Model
{
    public class FeedbackModel : Model
    {
        public UserModel User { get; set; }

        public ProjectModel Project { get; set; }

        public feedbackModel Level { get; set; }

        public string Text { get; set; }
    }

    public enum feedbackModel
    {
        D = 0,
        C = 1,
        B = 2,
        A = 3,
        S = 4
    }
}