namespace user.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public int name { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}