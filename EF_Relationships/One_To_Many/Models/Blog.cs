namespace One_To_Many.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required,MaxLength(200)]
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }
}
