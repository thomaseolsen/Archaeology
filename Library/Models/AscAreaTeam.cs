using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class AscAreaTeam
    {
        public Guid Id { get; set; }
        public Guid AreaId { get; set; }
        public Guid TeamId { get; set; }

        public virtual Area Area { get; set; }
        public virtual Team Team { get; set; }
    }
}
