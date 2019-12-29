namespace HotelSuperbl.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Room_category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Room_category()
        {
            Hotel_room = new HashSet<Hotel_room>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_category { get; set; }

        [Required]
        [StringLength(50)]
        public string name { get; set; }

        public int number_of_rooms { get; set; }

        public int number_of_beds { get; set; }

        [Required]
        public string equipment { get; set; }

        [Column(TypeName = "money")]
        public decimal cost { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hotel_room> Hotel_room { get; set; }
    }
}
