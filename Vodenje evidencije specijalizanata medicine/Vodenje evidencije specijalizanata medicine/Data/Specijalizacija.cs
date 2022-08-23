namespace Vodenje_evidencije_specijalizanata_medicine.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Specijalizacija")]
    public partial class Specijalizacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Specijalizacija()
        {
            Kompetencije = new HashSet<Kompetencije>();
            RasporedPrograma = new HashSet<RasporedPrograma>();
            Zahvati = new HashSet<Zahvati>();
            ZavrsetakSpecijalizacije = new HashSet<ZavrsetakSpecijalizacije>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int id { get; set; }

        public int specijalizant { get; set; }

        [Column("specijalizacija")]
        [Required]
        [StringLength(1000)]
        public string specijalizacija1 { get; set; }

        [Required]
        [StringLength(150)]
        public string odobrena_za { get; set; }

        [StringLength(100)]
        public string klasa { get; set; }

        [StringLength(100)]
        public string ubroj { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum_rjesenja { get; set; }

        public int glavni_mentor { get; set; }

        [Column(TypeName = "date")]
        public DateTime datum_pocetka { get; set; }

        [StringLength(1000)]
        public string potpis_gl_mentora { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kompetencije> Kompetencije { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Korisnik Korisnik1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RasporedPrograma> RasporedPrograma { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Zahvati> Zahvati { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ZavrsetakSpecijalizacije> ZavrsetakSpecijalizacije { get; set; }
    }
}
