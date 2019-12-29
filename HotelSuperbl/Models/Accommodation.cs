namespace HotelSuperbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Accommodation")]
    public partial class Accommodation
    {
        [Key]
        public int ID_cost { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_cost { get; set; }

        public int reservation_code { get; set; }

        [Column(TypeName = "money")]
        public decimal cost_accomodation { get; set; }

        public virtual Reservation Reservation { get; set; }
    }
}
