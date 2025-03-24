namespace MyBlog.Blog.Dto
{
    public class BlogDto
    {
        public Guid Id { get; set; }

        public required string ShortTitle { get; set; }

        public required string LargeTitle { get; set; }

        public required string Body { get; set; }

        public DateTime CreatedTime { get; set; }
    }
}
