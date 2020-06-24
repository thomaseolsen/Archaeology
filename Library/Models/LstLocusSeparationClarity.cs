using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class LstLocusSeparationClarity
    {
        public LstLocusSeparationClarity()
        {
            Locus = new HashSet<Locus>();
        }

        public byte Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Locus> Locus { get; set; }
    }
}
