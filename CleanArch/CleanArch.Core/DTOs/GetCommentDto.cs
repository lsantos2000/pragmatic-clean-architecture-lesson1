using CleanArch.Core.Enums;

namespace CleanArch.Core.DTOs
{
    public class GetCommentDto
    {
        public int Id { get; set; }
        public int BlogPostId { get; set; }
        public int UserId { get; set; }
        public required string Description { get; set; }
        public DateTime DateCreated { get; set; }
        public ApprovalStatusEnum Status { get; set; }
    }
}
