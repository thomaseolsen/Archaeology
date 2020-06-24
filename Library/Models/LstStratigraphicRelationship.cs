using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LstStratigraphicRelationship
    {
        public LstStratigraphicRelationship()
        {
            AscLocusStratigraphy = new HashSet<AscLocusStratigraphy>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }
        public bool Architectural { get; set; }
        public bool Earth { get; set; }
        public bool Installation { get; set; }

        public virtual ICollection<AscLocusStratigraphy> AscLocusStratigraphy { get; set; }
    }
}
