using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstArchitecturalMasonry
    {
        public LstArchitecturalMasonry()
        {
            LocusDescriptionArchitectureMasonry = new HashSet<LocusDescriptionArchitectureMasonry>();
            LocusDescriptionInstallationMasonry = new HashSet<LocusDescriptionInstallationMasonry>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureMasonry> LocusDescriptionArchitectureMasonry { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMasonry> LocusDescriptionInstallationMasonry { get; set; }
    }
}
