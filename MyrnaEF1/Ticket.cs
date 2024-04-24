namespace MyrnaEF1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Ticket")]
    public partial class Ticket
    {
        public int TicketID { get; set; }

        [Required]
        [StringLength(50)]
        public string TicketType { get; set; }

        public int ScreeningID { get; set; }

        [Column(TypeName = "date")]
        public DateTime PurchaseDate { get; set; }

        [Required]
        [StringLength(50)]
        public string PatronName { get; set; }

        [Required]
        [StringLength(20)]
        public string PaymentType { get; set; }

        public virtual Screening Screening { get; set; }
    }
}
