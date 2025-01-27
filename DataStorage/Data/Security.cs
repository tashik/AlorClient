﻿using Common;
using LiteDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStorage
{
    internal class Security : ISecurity
    {
        [BsonId(true)]
        public long PrimeKey { get; set; }
        public required string Symbol { get; set; }

        public required string Exchange { get; set; }

        public required string Shortname { get; set; }

        public required string CfiCode { get; set; }

        public required DateTime Cancellation { get; set; }
    }
}
