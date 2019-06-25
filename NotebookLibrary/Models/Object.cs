using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class Object
    {
        public Guid Id { get; set; }
        public Guid LocusId { get; set; }
        public int Number { get; set; }
        public DateTime DateCollected { get; set; }
        public Guid GeospatialDataId { get; set; }
        public int CountTotal { get; set; }
        public bool LeftInField { get; set; }
        public string Remarks { get; set; }

        public virtual GeospatialData GeospatialData { get; set; }
        public virtual Locus Locus { get; set; }
    }
}
