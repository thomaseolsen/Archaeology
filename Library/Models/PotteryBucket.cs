using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class PotteryBucket
    {
        public Guid Id { get; set; }
        public Guid LocusId { get; set; }
        public int Number { get; set; }
        public DateTime DateFilled { get; set; }
        public Guid GeospatialDataId { get; set; }
        public int CountTotal { get; set; }
        public int CountRims { get; set; }
        public int CountHandles { get; set; }
        public int CountBases { get; set; }
        public bool BoneBag { get; set; }
        public string Remarks { get; set; }

        public virtual GeospatialData GeospatialData { get; set; }
        public virtual Locus Locus { get; set; }
    }
}
