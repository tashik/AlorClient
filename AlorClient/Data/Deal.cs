﻿using Common;
using System.Text.Json.Serialization;

namespace AlorClient
{
    internal class Deal : IDeal
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("existing")]
        public bool Existing { get; set; }

        [JsonPropertyName("price")]
        public double Price { get; set; }

        [JsonPropertyName("qty")]
        public int Quantity { get; set; }

        [JsonPropertyName("oi")]
        public int OpenInterest { get; set; }

        [JsonPropertyName("side")]
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public Side Side { get; set; }

        [JsonPropertyName("timestamp")]
        [JsonConverter(typeof(TimestampJsonConverter))]
        public DateTimeOffset Timestamp { get; set; }
        public DateTimeOffset ClientTimestamp { get; set; } = DateTimeOffset.Now;
    }
}
