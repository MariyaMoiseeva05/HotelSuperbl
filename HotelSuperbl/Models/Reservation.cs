namespace HotelSuperbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Reservation")]
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            Accommodations = new HashSet<Accommodation>();
        }

        [Key]
        public int reservation_code { get; set; }

        [Column(TypeName = "date")]
        public DateTime date_reservation { get; set; }

        [Column(TypeName = "date")]
        public DateTime arrival_dates { get; set; }

        [Column(TypeName = "date")]
        public DateTime dates_of_departure { get; set; }

        public int client_code { get; set; }

        public int ID_room { get; set; }

        public int Id_user { get; set; }

        public int? number_of_guests { get; set; }

        [StringLength(50)]
        public string status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Accommodation> Accommodations { get; set; }

        public virtual Client Client { get; set; }

        public virtual Hotel_room Hotel_room { get; set; }

        public virtual User User { get; set; }
    }
}
