namespace MyrnaEF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Show")]
    public partial class Show
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Show()
        {
            Screenings = new HashSet<Screening>();
        }

        public int ShowID { get; set; }

        [Required]
        [StringLength(60)]
        public string Title { get; set; }

        [Column(TypeName = "date")]
        public DateTime ShowDate { get; set; }

        [Required]
        [StringLength(30)]
        public string TypeOfShow { get; set; }

        public decimal Price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Screening> Screenings { get; set; }
    }
}
