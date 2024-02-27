namespace SingletonApp_NotThreadSafe
{
    public class LogMessages
    {
        public string Message { get; set; } = null!;
        public LogType LogType { get; set; }
        public DateTime CreateAt { get; set; }


        public override string ToString()
        {
            var timestamp = CreateAt.ToString("yyyy-MM-dd hh:mm");

            return $"{LogType.ToString().PadLeft(7, ' ')}  [{timestamp}] {Message}";
        }

    }
}
