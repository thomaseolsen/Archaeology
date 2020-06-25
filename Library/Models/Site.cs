using System;
using System.Collections.Generic;

namespace Library.Models
{
    public partial class Site
    {
        public Guid Id { get; set; }
        public string ShortName { get; set; }
        public string FullName { get; set; }
        public string PublicationName { get; set; }

        public virtual ICollection<Area> Area { get; set; }
    }
}
