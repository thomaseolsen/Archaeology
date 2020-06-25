using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstArchitecturalPreservation
    {
        public LstArchitecturalPreservation()
        {
            LocusDescriptionArchitecture = new HashSet<LocusDescriptionArchitecture>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitecture> LocusDescriptionArchitecture { get; set; }
    }
}
