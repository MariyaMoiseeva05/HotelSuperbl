namespace HotelSuperbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service_check
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id_check { get; set; }

        public int id_client { get; set; }

        public int id_addition_services { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        public int quantity { get; set; }

        [Column(TypeName = "money")]
        public decimal cost_service { get; set; }

        public bool payment { get; set; }

        public virtual Additional_services Additional_services { get; set; }

        public virtual Client Client { get; set; }
    }
}
