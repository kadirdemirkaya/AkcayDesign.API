namespace AkcayDesign.API.ResponseMessages
{
    public class Messages
    {
        public string message { get; set; }
        public bool isSuccess { get; set; }
        public DateTime Time { get; set; } = DateTime.Now;
    }
}
