using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class Team
    {
        public Team()
        {
            AscAreaTeam = new HashSet<AscAreaTeam>();
            Supervisor = new HashSet<Supervisor>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<AscAreaTeam> AscAreaTeam { get; set; }
        public virtual ICollection<Supervisor> Supervisor { get; set; }
    }
}
