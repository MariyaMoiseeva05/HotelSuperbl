namespace HotelSuperbl.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class HotelContext : DbContext
    {
        public HotelContext()
            : base("name=HotelContext")
        {
        }

        public virtual DbSet<Accommodation> Accommodations { get; set; }
        public virtual DbSet<Additional_services> Additional_services { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Hotel_room> Hotel_room { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Room_category> Room_category { get; set; }
        public virtual DbSet<Service_check> Service_check { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Accommodation>()
                .Property(e => e.cost_accomodation)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Additional_services>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Additional_services>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<Additional_services>()
                .Property(e => e.current_price)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Additional_services>()
                .HasMany(e => e.Service_check)
                .WithRequired(e => e.Additional_services)
                .HasForeignKey(e => e.id_addition_services)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.surname)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.patronymic)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.e_mail)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.citizenship)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.pasport_data)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Client>()
                .HasMany(e => e.Service_check)
                .WithRequired(e => e.Client)
                .HasForeignKey(e => e.id_client)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Hotel_room>()
                .Property(e => e.condition)
                .IsUnicode(false);

            modelBuilder.Entity<Hotel_room>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.Hotel_room)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Reservation>()
                .Property(e => e.status)
                .IsUnicode(false);

            modelBuilder.Entity<Reservation>()
                .HasMany(e => e.Accommodations)
                .WithRequired(e => e.Reservation)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Room_category>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<Room_category>()
                .Property(e => e.equipment)
                .IsUnicode(false);

            modelBuilder.Entity<Room_category>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Room_category>()
                .HasMany(e => e.Hotel_room)
                .WithRequired(e => e.Room_category)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Service_check>()
                .Property(e => e.cost_service)
                .HasPrecision(19, 4);

            modelBuilder.Entity<User>()
                .Property(e => e.full_name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.phone_number)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.position)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Reservations)
                .WithRequired(e => e.User)
                .WillCascadeOnDelete(false);
        }
    }
}
