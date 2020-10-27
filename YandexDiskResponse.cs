using System.Text.Json.Serialization;

namespace DictionaryBackup
{
    public class YandexDiskResponse
    {
        [JsonPropertyName("href")]
        public string? Link { get; set; }

        [JsonPropertyName("operation_id")]
        public string? OperationId { get; set; }

        [JsonPropertyName("method")]
        public string? Method { get; set; }

        [JsonPropertyName("templated")]
        public bool? Templated { get; set; }
    }
}