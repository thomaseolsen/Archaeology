using System;
using System.Collections.Generic;
using GeoAPI.Geometries;

namespace Library.Models
{
    public partial class GeospatialData
    {
        public GeospatialData()
        {
            Object = new HashSet<Object>();
            PotteryBucket = new HashSet<PotteryBucket>();
        }

        public Guid Id { get; set; }
        public int Number { get; set; }
        public IGeometry Gps { get; set; }
        public decimal? Easting { get; set; }
        public decimal? Northing { get; set; }

        public virtual LocusGeospatialDefinition LocusGeospatialDefinition { get; set; }
        public virtual ICollection<Object> Object { get; set; }
        public virtual ICollection<PotteryBucket> PotteryBucket { get; set; }
    }
}
