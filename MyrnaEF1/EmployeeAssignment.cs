namespace MyrnaEF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("EmployeeAssignment")]
    public partial class EmployeeAssignment
    {
        [Key]
        public int AssignmentID { get; set; }

        public int EmployeeID { get; set; }

        public int RoleID { get; set; }

        public int ScreeningID { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Screening Screening { get; set; }

        public virtual EmployeeRole EmployeeRole { get; set; }
    }
}
