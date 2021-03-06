﻿using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstArchitecturalMaterial
    {
        public LstArchitecturalMaterial()
        {
            LocusDescriptionArchitectureMaterial = new HashSet<LocusDescriptionArchitectureMaterial>();
            LocusDescriptionInstallationMaterial = new HashSet<LocusDescriptionInstallationMaterial>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureMaterial> LocusDescriptionArchitectureMaterial { get; set; }
        public virtual ICollection<LocusDescriptionInstallationMaterial> LocusDescriptionInstallationMaterial { get; set; }
    }
}
