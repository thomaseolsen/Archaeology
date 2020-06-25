using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LstEarthInclusionsStone
    {
        public LstEarthInclusionsStone()
        {
            LocusDescriptionEarthInclusionsStone = new HashSet<LocusDescriptionEarthInclusionsStone>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionEarthInclusionsStone> LocusDescriptionEarthInclusionsStone { get; set; }
    }
}
