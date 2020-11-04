using System;
using Newtonsoft.Json;

namespace Idex4Net.Domain.CoreModels
{
    public class Ticker
    {
        public string Market { get; set; }

        [JsonConverter(typeof(MicrosecondEpochConverter))]
        public DateTime? Time { get; set; }
        public decimal? Open { get; set; }
        public decimal? High { get; set; }
        public decimal? Low { get; set; }
        public decimal? Close { get; set; }
        public decimal? CloseQuantity { get; set; }
        public decimal BaseVolume { get; set; }
        public decimal QuoteVolume { get; set; }
        public decimal PercentChange { get; set; }
        public int NumTrades { get; set; }
        public decimal? Ask { get; set; }
        public decimal? Bid { get; set; }
        public int? Sequence { get; set; }
    }
}