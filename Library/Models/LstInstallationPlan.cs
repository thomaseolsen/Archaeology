using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstInstallationPlan
    {
        public LstInstallationPlan()
        {
            LocusDescriptionInstallation = new HashSet<LocusDescriptionInstallation>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionInstallation> LocusDescriptionInstallation { get; set; }
    }
}
