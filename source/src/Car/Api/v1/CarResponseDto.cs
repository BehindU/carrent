namespace CarRent.Car.Api.v1
{
    using System.Text.Json.Serialization;

    public class CarResponseDto
    {
        [JsonPropertyName("id")]
        [JsonPropertyOrder(100)]
        public Guid CarId { get; set; }

        [JsonPropertyName("car-number")]
        [JsonPropertyOrder(200)]
        public string CarNumber { get; set; }

        [JsonPropertyOrder(300)]
        public string Brand { get; set; }

        [JsonPropertyOrder(400)]
        public string CarClass { get; set; }

        [JsonPropertyOrder(500)]
        public string Type { get; set; }
    }
}
