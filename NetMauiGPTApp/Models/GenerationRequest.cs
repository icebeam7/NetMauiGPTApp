using System.Text.Json.Serialization;

namespace NetMauiGPTApp.Models
{
	public class GenerationRequest
	{
		[JsonPropertyName("prompt")]
		public string Prompt { get; set; }

		[JsonPropertyName("n")]
		public int N { get; set; } = 1;

		[JsonPropertyName("size")]
		public string Size { get; set; } = "512x512";
	}
}