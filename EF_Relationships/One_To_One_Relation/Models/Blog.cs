namespace One_To_One_Relation.Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required,MaxLength(200)]
        public string Url { get; set; }

        public BlogImage BlogImage { get; set; }

    }
}
