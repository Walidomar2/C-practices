namespace Many_To_Many.Models
{
    public class Tag
    {
        public string TagId { get; set; }
        public ICollection<Post> Posts { get; set; }

        public List<PostTags> PostTags { get; set; }
    }
}
