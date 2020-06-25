using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class LocusDescriptionArchitectureFacing
    {
        public Guid Id { get; set; }
        public Guid LocusDescriptionArchitectureId { get; set; }
        public byte ArchitecturalFacingId { get; set; }
        public byte Percentage { get; set; }
        public short MunselNumberId { get; set; }
        public string Remarks { get; set; }

        public virtual LstArchitecturalFacing ArchitecturalFacing { get; set; }
        public virtual LocusDescriptionArchitecture LocusDescriptionArchitecture { get; set; }
        public virtual LstMunsellNumber MunselNumber { get; set; }
    }
}
