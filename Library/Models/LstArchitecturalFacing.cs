using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstArchitecturalFacing
    {
        public LstArchitecturalFacing()
        {
            LocusDescriptionArchitectureFacing = new HashSet<LocusDescriptionArchitectureFacing>();
            LocusDescriptionInstallationFacing = new HashSet<LocusDescriptionInstallationFacing>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureFacing> LocusDescriptionArchitectureFacing { get; set; }
        public virtual ICollection<LocusDescriptionInstallationFacing> LocusDescriptionInstallationFacing { get; set; }
    }
}
