namespace ASP_Core_Middlewares.Authentication
{
    public class JwtOptions
    {
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int LifeTime { get; set; }
        public string SigningKey { get; set; }
    }
}
