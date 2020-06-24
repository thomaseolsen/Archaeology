using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LocusGeospatialDefinition
    {
        public Guid GeospatialDataId { get; set; }
        public bool Top { get; set; }
        public bool Bottom { get; set; }
        public bool Edge { get; set; }
        public bool Reference { get; set; }

        public virtual GeospatialData GeospatialData { get; set; }
    }
}
