﻿using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class Area
    {
        public Area()
        {
            AscAreaTeam = new HashSet<AscAreaTeam>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Objective { get; set; }

        public virtual ICollection<AscAreaTeam> AscAreaTeam { get; set; }
    }
}
