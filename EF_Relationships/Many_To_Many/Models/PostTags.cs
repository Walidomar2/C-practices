namespace Many_To_Many.Models
{
    public class PostTags
    {
        public Post post { get; set; }
        public int PostId { get; set; }

        public Tag Tag { get; set; }
        public string TagId { get; set; }

        public DateTime AddOn { get; set; }
    }
}
