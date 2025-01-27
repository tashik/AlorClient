﻿using System.Text.Json.Serialization;
using Common;

namespace AlorClient
{
    public sealed class DealsSubscription : SecuritySubscription
    {
        [JsonPropertyName("includeVirtualTrades")]
        public bool IncludeVirtualTrades { get; }

        [JsonPropertyName("depth")]
        public int Depth { get; }

        public DealsSubscription(ISecurity security, bool includeVirtualTrades, int depth) : base(security, "AllTradesGetAndSubscribe")
        {
            IncludeVirtualTrades = includeVirtualTrades;
            Depth = depth;
        }

        public DealsSubscription(ISecurity security) : this(security, false, 0)
        {

        }
    }
}
