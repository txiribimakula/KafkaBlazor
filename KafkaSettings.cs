namespace BlazorApp
{
    public class KafkaSettings
    {
        public string? BootstrapServers { get; set; }

        public string? SaslUsername { get; set; }

        public string? SaslPassword { get; set; }
    }
}
