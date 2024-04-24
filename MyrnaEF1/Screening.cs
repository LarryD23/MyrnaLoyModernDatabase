namespace MyrnaEF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Screening
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Screening()
        {
            EmployeeAssignments = new HashSet<EmployeeAssignment>();
            Tickets = new HashSet<Ticket>();
        }

        public int ScreeningID { get; set; }

        public int ShowID { get; set; }

        [Required]
        [StringLength(60)]
        public string Theater { get; set; }

        public TimeSpan ScreeningTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeAssignment> EmployeeAssignments { get; set; }

        public virtual Show Show { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
