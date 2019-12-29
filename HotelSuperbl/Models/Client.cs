namespace HotelSuperbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Client")]
    public partial class Client
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Client()
        {
            Reservations = new HashSet<Reservation>();
            Service_check = new HashSet<Service_check>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int client_code { get; set; }

        [Required]
        [StringLength(50)]
        public string surname { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        [StringLength(50)]
        public string patronymic { get; set; }

        [Required]
        [StringLength(20)]
        public string phone_number { get; set; }

        [Required]
        [StringLength(50)]
        public string e_mail { get; set; }

        [Required]
        [StringLength(50)]
        public string citizenship { get; set; }

        [Required]
        public string pasport_data { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Service_check> Service_check { get; set; }
    }
}
