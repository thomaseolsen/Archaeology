using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class Locus
    {
        public Locus()
        {
            AscLocusStratigraphyCurrentLocus = new HashSet<AscLocusStratigraphy>();
            AscLocusStratigraphyRelatedLocus = new HashSet<AscLocusStratigraphy>();
            Object = new HashSet<Object>();
            PotteryBucket = new HashSet<PotteryBucket>();
        }

        public Guid Id { get; set; }
        public Guid SquareId { get; set; }
        public int Number { get; set; }
        public DateTime? DateOpened { get; set; }
        public DateTime? DateClosed { get; set; }
        public string Designation { get; set; }
        public string Reason { get; set; }
        public byte SeparationClarityId { get; set; }
        public string Function { get; set; }
        public string Stratigraphy { get; set; }
        public bool CleanLocus { get; set; }
        public string PeriodDate { get; set; }
        public string Phase { get; set; }
        public string Stratum { get; set; }

        public virtual LstLocusSeparationClarity SeparationClarity { get; set; }
        public virtual Square Square { get; set; }
        public virtual LocusDescriptionArchitecture LocusDescriptionArchitecture { get; set; }
        public virtual LocusDescriptionEarth LocusDescriptionEarth { get; set; }
        public virtual LocusDescriptionInstallation LocusDescriptionInstallation { get; set; }
        public virtual ICollection<AscLocusStratigraphy> AscLocusStratigraphyCurrentLocus { get; set; }
        public virtual ICollection<AscLocusStratigraphy> AscLocusStratigraphyRelatedLocus { get; set; }
        public virtual ICollection<Object> Object { get; set; }
        public virtual ICollection<PotteryBucket> PotteryBucket { get; set; }
    }
}
