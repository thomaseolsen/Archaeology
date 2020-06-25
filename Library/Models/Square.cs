using System;
using System.Collections.Generic;
using GeoAPI.Geometries;

namespace Library.Models
{
    public partial class Square
    {
        public Square()
        {
            Locus = new HashSet<Locus>();
        }

        public Guid Id { get; set; }
        public Guid AreaId { get; set; }
        public string Name { get; set; }
        public Guid SupervisorId { get; set; }
        public IGeometry Coordinates { get; set; }

        public virtual Area Area { get; set; }
        public virtual Supervisor Supervisor { get; set; }
        public virtual ICollection<Locus> Locus { get; set; }
    }
}
