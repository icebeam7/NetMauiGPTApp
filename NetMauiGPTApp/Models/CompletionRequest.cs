using System.Text.Json.Serialization;

namespace NetMauiGPTApp.Models
{
	public class CompletionRequest
	{
        [JsonPropertyName("model")]
        public string Model { get; set; } = "text-davinci-003";

		[JsonPropertyName("prompt")]
		public string Prompt { get; set; }

		[JsonPropertyName("temperature")]
		public double Temperature { get; set; } = 1;

		[JsonPropertyName("max_tokens")]
		public int MaxTokens { get; set; } = 100;
    }
}
