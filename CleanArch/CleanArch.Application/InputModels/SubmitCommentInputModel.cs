namespace CleanArch.Application.InputModels
{
    public class SubmitCommentInputModel
    {
        public int BlogPostId { get; set; }
        public int UserId { get; set; }
        public required string Description { get; set; }
    }
}
