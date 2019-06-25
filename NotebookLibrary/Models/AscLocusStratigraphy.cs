using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class AscLocusStratigraphy
    {
        public Guid Id { get; set; }
        public Guid CurrentLocusId { get; set; }
        public byte StratigraphicRelationshipId { get; set; }
        public Guid RelatedLocusId { get; set; }
        public string Remarks { get; set; }

        public virtual Locus CurrentLocus { get; set; }
        public virtual Locus RelatedLocus { get; set; }
        public virtual LstStratigraphicRelationship StratigraphicRelationship { get; set; }
    }
}
