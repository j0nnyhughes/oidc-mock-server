using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Web.Host.TokenGeneration
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GenerateAccessToken
    {
        public string ClientId { get; set; }
        public string Scope { get; set; }
    }
}