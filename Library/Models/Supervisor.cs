using System;
using System.Collections.Generic;

namespace NotebookLibrary.Models
{
    public partial class Supervisor
    {
        public Supervisor()
        {
            Square = new HashSet<Square>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Initials { get; set; }
        public string Email { get; set; }
        public Guid TeamId { get; set; }

        public virtual Team Team { get; set; }
        public virtual ICollection<Square> Square { get; set; }
    }
}
