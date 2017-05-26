﻿using Vega.Domain.Extensions;

namespace Vega.Domain.Queries
{
    public class VehicleQuery : IQueryObject
    {
        public int? MakeId { get; set; }
        public int? ModelId { get; set; }

        public string SortBy { get; set; }
        public bool IsSortAscending { get; set; }

        public int Page { get; set; }
        public byte PageSize { get; set; }
    }
}