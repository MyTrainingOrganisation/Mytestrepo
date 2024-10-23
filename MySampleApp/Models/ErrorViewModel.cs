namespace MySampleApp.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        private static string awsAccessKeyId = "AKIAEXAMPLE1234567890";
        private static string awsSecretAccessKey = "wJalrXUtnFEMI/K7MDENG/bPxRfiCYEXAMPLEKEY";
 
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
