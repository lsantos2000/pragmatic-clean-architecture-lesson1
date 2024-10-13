namespace CleanArch.Core.DTOs
{
    public class SubmitCommentDto
    {
        public int BlogPostId { get; set; }
        public int UserId { get; set; }
        public required string Description { get; set; }
    }
}
