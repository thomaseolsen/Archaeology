using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LstArchitecturalMortar
    {
        public LstArchitecturalMortar()
        {
            LocusDescriptionArchitectureMortar = new HashSet<LocusDescriptionArchitectureMortar>();
            LocusDescriptionInstallationMortar = new HashSet<LocusDescriptionInstallationMortar>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureMortar> LocusDescriptionArchitectureMortar { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMortar> LocusDescriptionInstallationMortar { get; set; }
    }
}
