using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LstMunsellNumber
    {
        public LstMunsellNumber()
        {
            LocusDescriptionArchitectureFacing = new HashSet<LocusDescriptionArchitectureFacing>();
            LocusDescriptionEarth = new HashSet<LocusDescriptionEarth>();
        }

        public short Id { get; set; }
        public string Hue { get; set; }
        public string Value { get; set; }
        public string Chroma { get; set; }
        public string Description { get; set; }

        public virtual ICollection<LocusDescriptionArchitectureFacing> LocusDescriptionArchitectureFacing { get; set; }
        public virtual ICollection<LocusDescriptionEarth> LocusDescriptionEarth { get; set; }
    }
}
