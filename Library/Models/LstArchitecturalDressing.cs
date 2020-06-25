using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstArchitecturalDressing
    {
        public LstArchitecturalDressing()
        {
            LocusDescriptionArchitectureDressing = new HashSet<LocusDescriptionArchitectureDressing>();
            LocusDescriptionInstallationDressing = new HashSet<LocusDescriptionInstallationDressing>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureDressing> LocusDescriptionArchitectureDressing { get; set; }
        public virtual ICollection<LocusDescriptionInstallationDressing> LocusDescriptionInstallationDressing { get; set; }
    }
}
