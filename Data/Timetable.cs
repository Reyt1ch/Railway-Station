//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RailwayStation.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Timetable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Timetable()
        {
            this.CancelledRaces = new HashSet<CancelledRace>();
            this.Reservations = new HashSet<Reservation>();
        }
    
        public int id { get; set; }
        public int race { get; set; }
        public int departingDay { get; set; }
        public System.TimeSpan departingTime { get; set; }
        public int arrivalDay { get; set; }
        public System.TimeSpan arrivalTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CancelledRace> CancelledRaces { get; set; }
        public virtual Day Day { get; set; }
        public virtual Day Day1 { get; set; }
        public virtual Race Race1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}